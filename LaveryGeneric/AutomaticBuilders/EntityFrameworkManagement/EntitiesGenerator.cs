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
        List<String> lTableContext = new List<String>();

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
        public EntitiesGenerator(connectionFactory OCF, String sBaseTableName, String dSecondTableName, String dThirdTableName) 
        {
            try
            {
                this.OCF = OCF;                
                lTableAssociated.Add(dSecondTableName);
                lTableAssociated.Add(dThirdTableName);
                this.sBaseTableName = sBaseTableName;
                sQlGeneration = String.Format(LaverySql.sSqlForThreeEntities, sBaseTableName, dSecondTableName, dThirdTableName);
                oConnectionSource = new SqlConnection(OCF.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();                

            }
            catch
            {

            }
        }
        public void doJob(String oDataEndpoint, String sNameSpace)
        {
            try
            {
                classBuilderFromTableDefinition oCBD = new classBuilderFromTableDefinition(OCF);
                String sPath = OCF.getKeyValueString("oDataGenerationPath");
                lTableContext.AddRange(oCBD.genereEntities(oConnectionSource, sNameSpace, sPath, sQlGeneration, lTableAssociated));
                genereEntityContext(oDataEndpoint, sNameSpace, sPath, "Controllers");
                genereEntityController(oDataEndpoint, sNameSpace, sPath, "Controllers");
                genereWebConfig(oDataEndpoint, sNameSpace, sPath, "App_Start");
            }
            catch
            {

            }
            
        }
        private void genereEntityContext(String sCODataEndPoint, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                String sDbSet = "";

                foreach (String sEntity in lTableContext)
                {
                    String sEntry = String.Format(LaveryTemplates.sDbSetTemplate, sEntity);
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
        private void genereEntityController(String sCODataEndPoint, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                
                
                String sControllerClass = String.Format(LaveryTemplates.sODataControllerTemplate, sNameSpace, sCODataEndPoint, sBaseTableName);
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
        private void genereWebConfig(String sCODataEndPoint, String sNameSpace, String sPath, String sSubFolder)
        {
            try
            {
                
                String sEntry = String.Format(LaveryTemplates.sODataBuilder, sBaseTableName, sCODataEndPoint);
                String sBuilder = String.Format("\t\t\t{0}\n", sEntry);
                foreach (String sEntity in lTableContext)
                {
                    if (!sEntity.Equals(sBaseTableName))
                    {
                        sEntry = String.Format(LaveryTemplates.sODataBuilder, sEntity, sEntity);
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
