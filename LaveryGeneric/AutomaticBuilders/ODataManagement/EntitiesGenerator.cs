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

        List<String> lBaseTableName = new List<String>();
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
        public EntitiesGenerator(connectionFactory OCF, List<String> lBaseTableName, List<String> lLinkedTableName) 
        {
            try
            {
                this.OCF = OCF;                
                this.lTableAssociated.AddRange(lLinkedTableName);
                this.lBaseTableName.AddRange(lBaseTableName);
                String sSetOfSqlTable = "";
                String sSep = "";
                foreach (String sTable in lTableAssociated)
                {
                    sSetOfSqlTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep  = ", ";
                }
                String sSetOfBaseSqlTable = "";
                sSep = "";
                foreach (String sTable in lBaseTableName)
                {
                    sSetOfBaseSqlTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep = ", ";
                }

                if (lTableAssociated.Count == 0)
                    sQlGeneration = String.Format(LaverySql.sSqlForSimpleEntitieDescriptions, sSetOfBaseSqlTable);
                else
                    sQlGeneration = String.Format(LaverySql.sSqlForComplexEntitieDescriptions, sSetOfBaseSqlTable, sSetOfSqlTable);

                oConnectionSource = new SqlConnection(OCF.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();                

            }
            catch
            {

            }
        }
        public EntitiesGenerator(connectionFactory OCF, List<String> lBaseTableName, 
                                    List<String> lTableNameInverseRelation, 
                                    List<String> lTableDirectRelationToInclude = default(List<String>))
        {
            try
            {
                this.OCF = OCF;
                lTableAssociated.AddRange(lTableNameInverseRelation);
                this.lTableDirectRelationToInclude = lTableDirectRelationToInclude;
                if (lTableDirectRelationToInclude != default(List<String>))
                    this.lTableDirectRelationToInclude.AddRange(lBaseTableName);

                this.lBaseTableName.AddRange(lBaseTableName);

                String sSetOfSqlTable = "";
                String sSep = "";
                foreach (String sTable in lTableAssociated)
                {
                    sSetOfSqlTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep = ", ";
                }
                String sSetOfSqlBaseTable = "";
                sSep = "";
                foreach (String sTable in lBaseTableName)
                {
                    sSetOfSqlBaseTable += String.Format("{0}'{1}'", sSep, sTable);
                    sSep = ", ";
                }
                if (lTableNameInverseRelation.Count > 0)
                    sQlGeneration = String.Format(LaverySql.sSqlForComplexEntitieDescriptions, sSetOfSqlBaseTable, sSetOfSqlTable);
                else
                    sQlGeneration = String.Format(LaverySql.sSqlForSimpleEntitieDescriptions, sSetOfSqlBaseTable);
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
                foreach(String sBaseTableName in lBaseTableName)
                    oCBD.OEntitySet.Add(sBaseTableName, sBaseTableName +"s");
                Array.ForEach(Directory.GetFiles(sPath + @"\Models\"), delegate (string path) { File.Delete(path); });
                Array.ForEach(Directory.GetFiles(sPath + @"\Controllers\"), delegate (string path) { File.Delete(path); });
                oCBD.genereEntities(oConnectionSource, sNameSpace, sPath, sQlGeneration, lTableAssociated, lTableDirectRelationToInclude);
                String sKey = getPrimaryKey(oCBD.OCompleteDicoField);
                String sType = getPrimaryKeyType(oCBD.OCompleteDicoField);
                genereEntityContext(oDataEndpoint, oCBD.OEntitySet, sNameSpace, sPath, "Controllers");
                genereEntityController(oDataEndpoint, sKey, sType, sNameSpace, sPath, "Controllers");

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
                    String sBaseTableName = lBaseTableName[0];
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
        private String getPrimaryKeyType(Dictionary<String, fieldDef> oDicoField)
        {
            String sRet = "Missing Key";
            try
            {
                foreach (KeyValuePair<String, fieldDef> oEntry in oDicoField.OrderBy(ch => ch.Key).ToList())
                {
                    String sEntTableName = oEntry.Key.Split('|')[0];
                    String sBaseTableName = lBaseTableName[0];
                    if (sEntTableName.Equals(sBaseTableName, StringComparison.CurrentCultureIgnoreCase))
                        if (oEntry.Value.IsPK)
                        {
                            sRet = oEntry.Value.OType.Name;
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
        private void genereEntityController(String sCODataEndPoint, String sPrimayKey, String sPrimayKeyType, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                
                
                String sControllerClass = String.Format(LaveryTemplates.sODataControllerTemplate, sNameSpace, sCODataEndPoint, lBaseTableName[0], sPrimayKey, sPrimayKeyType);
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
                
                String sEntry = String.Format(LaveryTemplates.sODataBuilderEntityset, lBaseTableName[0], sCODataEndPoint);
                String sBuilder = String.Format("\t\t\t{0}\n", sEntry);
                foreach (KeyValuePair<String, String> oEntity in dicoEntitySet)
                {
                    if (!oEntity.Key.Equals(lBaseTableName[0]))
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
