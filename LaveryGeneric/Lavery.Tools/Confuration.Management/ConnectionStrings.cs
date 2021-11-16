using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Tools.Interfaces;


namespace Lavery.Tools.Configuration.Management
{ 
    public class ConnectionStrings 
    {
        String sPhysicalLocation = "";
        String sFullPath = "";
        int iMasterDbo;
        String sRessourceName = "";
        String sConnectString = "";
        String sUserId = "";
        String sPassword = "";
        String sLOB = "";
        ConnType.eConnType eDBType = ConnType.eConnType.NOTHING;
        

        

        public String SLOB
        {
            get { return sLOB; }
            set { sLOB = value; }
        }

        

        public String SUserId
        {
            get { return sUserId; }
            set { sUserId = value; }
        }

        public String SPassword
        {
            get { return sPassword; }
            set { sPassword = value; }
        }
        public ConnType.eConnType EDBType
        {
            get { return eDBType; }
            set { eDBType = value; }
        }



        public String SPhysicalLocation
        {
            get { return sPhysicalLocation; }
            set { sPhysicalLocation = value; }
        }
        public String SFullPath
        {
            get { return sFullPath; }
            set { sFullPath = value; }
        }
        public int IMasterDbo
        {
            get { return iMasterDbo; }
            set { iMasterDbo = value; }
        }

        public String SConnectString
        {
            get { return sConnectString; }
            set { sConnectString = value; }
        }
        public String SRessourceName
        {
            get { return sRessourceName; }
            set { sRessourceName = value; }
        }
        public static int CompareConnectStringObject(ConnectionStrings x, ConnectionStrings y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    string s1 = x.SPhysicalLocation + "|" + x.IMasterDbo;
                    string s2 = y.SPhysicalLocation + "|" + y.IMasterDbo;
                    int retval = s1.Length.CompareTo(s2.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        s1 = s1.ToUpper();
                        s2 = s2.ToUpper();
                        return s1.CompareTo(s2);
                    }
                }
            }
        }
        public ConnectionStrings(String sWithConnectString)
        {
            // "Initial Catalog = master;"
            try
            {
                sConnectString = "";
                char[] sSep = new char[1];
                sSep[0] = ';';
                String[] sVal1 = sWithConnectString.Split(sSep);
                iMasterDbo = 1;
                foreach (String sElement1 in sVal1)
                {

                    sSep[0] = '=';
                    String[] sVal2 = sElement1.Split(sSep);
                    String sKey = sVal2[0].Replace(" ", "");
                    if (sKey.Equals("providerName", StringComparison.CurrentCultureIgnoreCase))
                    {
                        String sProvider = sVal2[sVal2.Length - 1];
                       
                        EDBType = ConnType.eConnType.NOTHING;
                       
                        if (sProvider.Equals("MSSQL", StringComparison.CurrentCultureIgnoreCase))
                            EDBType = ConnType.eConnType.SQLSERVER;
                    }
                    if (sKey.Equals("LOB", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sLOB = sVal2[sVal2.Length - 1];
                    }
                    if (sKey.Equals("DataSource", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sPhysicalLocation = sVal2[sVal2.Length - 1];
                    }
                    if (sKey.Equals("Url", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sPhysicalLocation = sVal2[sVal2.Length - 1];
                    }
                    if (sKey.Equals("Root", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sFullPath = sVal2[sVal2.Length - 1];
                    }
                    if (sKey.Equals("Server", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sPhysicalLocation = sVal2[sVal2.Length - 1];
                    }

                    if (sKey.Equals("InitialCatalog", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sRessourceName = sVal2[sVal2.Length - 1];
                       
                        if (sRessourceName.Equals("master", StringComparison.CurrentCultureIgnoreCase) ||
                            sRessourceName.Equals("Information_Schema", StringComparison.CurrentCultureIgnoreCase))
                            iMasterDbo = 0;
                  
                    }
                    if (sKey.Equals("Userid", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sUserId = sVal2[sVal2.Length - 1];
                    }
                    if (sKey.Equals("PassWord", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sPassword = sVal2[sVal2.Length - 1];
                    }
                    if (sConnectString.Length > 0)
                        sConnectString += ";";
                    if (!sKey.Equals("providerName", StringComparison.CurrentCultureIgnoreCase) &&
                        !sKey.Equals("LOB", StringComparison.CurrentCultureIgnoreCase))
                        sConnectString += (sVal2[0] + "=" + sVal2[sVal2.Length - 1]);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }


        }
    }
}
