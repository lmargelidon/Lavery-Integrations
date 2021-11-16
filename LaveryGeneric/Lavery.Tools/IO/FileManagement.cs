using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lavery.Tools.IO
{
    public class FileManagement
    {
        static public String formatFileNameWithExtension(String sWithLocation, String sWithFile, String sWithExtension)
        {
            String sRet = "";
            try
            {
                sWithLocation = sWithLocation.Trim();
                sWithFile = sWithFile.Trim();
                if (sWithFile.LastIndexOf(@"\") > 0)
                    sWithFile = sWithFile.Substring(sWithFile.LastIndexOf(@"\") + 1).Trim();

                if (sWithLocation.Substring(sWithLocation.Length - 1, 1).Equals(@"\"))
                    sRet = sWithLocation + sWithFile;
                else
                    sRet = sWithLocation + @"\" + sWithFile;
                if(!sRet.Substring(sRet.Length -  sWithExtension.Length + 1 , sWithExtension.Length).Equals(sWithExtension, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (sRet.IndexOf(".") > 0)
                        sRet = sRet.Substring(0, sRet.IndexOf(".")) + "." + sWithExtension;
                    else
                        sRet = sRet + "." + sWithExtension;
                }

            }
            catch (Exception ex)
            {
                
            }
            return sRet;

        }
        static public Boolean deployFiles(String sSourceDeployementLocation, String sTargetDeployementLocation, String sWithFileOrWidCard)
        {
            Boolean bRet = false;
            try
            {
                sSourceDeployementLocation = sSourceDeployementLocation.Trim();
                sTargetDeployementLocation = sTargetDeployementLocation.Trim();
                if (sSourceDeployementLocation.Substring(sSourceDeployementLocation.Length - 1, 1).Equals(@"\"))
                    sSourceDeployementLocation = sSourceDeployementLocation.Substring(0, sSourceDeployementLocation.Length - 1);
                if (sTargetDeployementLocation.Substring(sTargetDeployementLocation.Length - 1, 1).Equals(@"\"))
                    sTargetDeployementLocation = sTargetDeployementLocation.Substring(0, sTargetDeployementLocation.Length - 1);
                if (Directory.Exists(sSourceDeployementLocation))
                {
                    if (!Directory.Exists(sTargetDeployementLocation))
                        Directory.CreateDirectory(sTargetDeployementLocation);
                    string[] files = Directory.GetFiles(sSourceDeployementLocation, sWithFileOrWidCard);
                    foreach (string file in files)
                    {
                        String sFile = file.Substring(file.LastIndexOf(@"\") + 1);
                        File.Copy(sSourceDeployementLocation + @"\" + sFile, sTargetDeployementLocation + @"\" + sFile, true);
                    }
                    bRet = true;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
    }
}
