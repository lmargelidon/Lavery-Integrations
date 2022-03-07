using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Helper.ClassGenerator;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;

namespace EF.Entities.management
{
    public class EntitiesGenerator : Object, IDisposable
    {
        connectionFactory OCF;
        List<String> lTableAssociated = new List<String>();
        
        List<String> lTableDirectRelationToInclude;

        String sBaseTableName;
        SqlConnection oConnectionSource;
        Boolean disposing;
        Boolean Disposed;
        String sQlGeneration;


        ~EntitiesGenerator() => Dispose(false);

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.Disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {

                }

                oConnectionSource.Close();
                Disposed = true;
            }
        }
        public EntitiesGenerator(connectionFactory OCF, String sBaseTableName, List<String> lLinkedTableName) 
        {
            try
            {
                this.OCF = OCF;                
                lTableAssociated.AddRange(lLinkedTableName);
                this.sBaseTableName = sBaseTableName;
                String sSetOfSqlTable = "";
                String sSep = "";
                foreach (String sTable in lTableAssociated)
                {
                    sSetOfSqlTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep  = ", ";
                }
                sQlGeneration = String.Format(LaverySql.sSqlForTEntitieDescriptions, sBaseTableName, sSetOfSqlTable);
                oConnectionSource = new SqlConnection(OCF.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();                

            }
            catch
            {

            }
        }
        public EntitiesGenerator(connectionFactory OCF, String sSQlTemplate, String sBaseTableName, 
                                    List<String> lTableNameInverseRelation, 
                                    List<String> lTableDirectRelationToInclude = default(List<String>))
        {
            try
            {
                this.OCF = OCF;
                lTableAssociated.AddRange(lTableNameInverseRelation);
                this.lTableDirectRelationToInclude = lTableDirectRelationToInclude;
                if (lTableDirectRelationToInclude != default(List<String>))
                    this.lTableDirectRelationToInclude.Add(sBaseTableName);

                this.sBaseTableName = sBaseTableName;

                String sSetOfSqlTable = "";
                String sSep = "";
                foreach (String sTable in lTableAssociated)
                {
                    sSetOfSqlTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep = ", ";
                }
                sQlGeneration = String.Format(LaverySql.sSqlForTEntitieDescriptions, sBaseTableName, sSetOfSqlTable);
                oConnectionSource = new SqlConnection(OCF.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();

            }
            catch
            {

            }
        }
        public void doJob(String sPath, String oDataEndpoint, String sNameSpace, Boolean isForEntityFramework)
        {
            try
            {
                classBuilderFromTableDefinition oCBD = new classBuilderFromTableDefinition(OCF);
                oCBD.OEntitySet.Add(sBaseTableName, sBaseTableName +"s");
                Array.ForEach(Directory.GetFiles(sPath + @"\Models\"), delegate (string path) { File.Delete(path); });
                Array.ForEach(Directory.GetFiles(sPath + @"\Controllers\"), delegate (string path) { File.Delete(path); });
                oCBD.genereEntities(oConnectionSource, sNameSpace, sPath, sQlGeneration, lTableAssociated, lTableDirectRelationToInclude);
                String sKey = getPrimaryKey(oCBD.OCompleteDicoField);
                
                genereEntityContext(oDataEndpoint, oCBD.OEntitySet, sNameSpace, sPath, "Controllers");
                genereEntityController(oDataEndpoint, sKey, sNameSpace, sPath, "Controllers");
                genereWebConfig(oDataEndpoint, oCBD.OEntitySet, sNameSpace, sPath, "App_Start");
                
            }
            catch(Exception ex)
            {

            }
            
        }
        private String getPrimaryKey(Dictionary<String, fieldDef> oDicoField)
        {
            String sRet = "Missing Key";
            try
            {
                foreach (KeyValuePair<String, fieldDef> oEntry in oDicoField.OrderBy(ch => ch.Key).ToList())
                {
                    String sEntTableName = oEntry.Key.Split('|')[0];
                    if (sEntTableName.Equals(sBaseTableName, StringComparison.CurrentCultureIgnoreCase))
                        if (oEntry.Value.IsPK)
                        {
                            sRet = oEntry.Value.SName;
                            break;
                        }
                }
            }
            catch (Exception ex)
            { }

            return sRet;
        }
        private void genereEntityContext(String sCODataEndPoint, Dictionary<String, String> dicoEntitySet, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                String sDbSet = "";

                foreach (KeyValuePair<String, String>  oEntity in dicoEntitySet)
                {
                    String sEntry = String.Format(LaveryTemplates.sDbSetTemplate, oEntity.Key, oEntity.Value);
                    sDbSet += String.Format("\t\t{0}\n", sEntry);
                }

                String sContextClass = String.Format(LaveryTemplates.sOdataClasseContextTemplate, sNameSpace, sCODataEndPoint, sDbSet);
                if (sPath[sPath.Length - 1] != '\\')
                    sPath += '\\';
                if (sSubFolder != default(String))
                    sPath += (sSubFolder + '\\');
                using (var sw = new StreamWriter(string.Format("{0}{1}Context.cs", sPath, sCODataEndPoint)))
                    sw.WriteLine(sContextClass);

            }
            catch(Exception ex)
            {

            }
        }
        private void genereEntityController(String sCODataEndPoint, String sPrimayKey, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                
                
                String sControllerClass = String.Format(LaveryTemplates.sODataControllerTemplate, sNameSpace, sCODataEndPoint, sBaseTableName, sPrimayKey);
                if (sPath[sPath.Length - 1] != '\\')
                    sPath += '\\';
                if (sSubFolder != default(String))
                    sPath += (sSubFolder + '\\');
                using (var sw = new StreamWriter(string.Format("{0}{1}Controller.cs", sPath, sCODataEndPoint)))
                    sw.WriteLine(sControllerClass);

            }
            catch (Exception ex)
            {

            }
        }
        private void genereWebConfig(String sCODataEndPoint, Dictionary<String, String> dicoEntitySet, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                
                String sEntry = String.Format(LaveryTemplates.sODataBuilderEntityset, sBaseTableName, sCODataEndPoint);
                String sBuilder = String.Format("\t\t\t{0}\n", sEntry);
                foreach (KeyValuePair<String, String> oEntity in dicoEntitySet)
                {
                    if (!oEntity.Key.Equals(sBaseTableName))
                    {
                        sEntry = String.Format(LaveryTemplates.sODataBuilderEntityset, oEntity.Key, oEntity.Value);
                        sBuilder += String.Format("\t\t\t{0}\n", sEntry);
                    }
                }

                String sContextClass = String.Format(LaveryTemplates.sODataWindowsApiConfigTemplate, sNameSpace, sBuilder);
                if (sPath[sPath.Length - 1] != '\\')
                    sPath += '\\';
                if (sSubFolder != default(String))
                    sPath += (sSubFolder + '\\');
                using (var sw = new StreamWriter(string.Format("{0}WebApiConfig.cs", sPath )))
                    sw.WriteLine(sContextClass);

            }
            catch (Exception ex)
            {

            }
        }

    }
}
