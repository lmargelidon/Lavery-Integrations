using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Lavery.Tools.IO
{
    public class streamManagement
    {
        static public  Stream GenerateStreamFromString(String p)
        {
            MemoryStream oStream = null;
            try
            {
                Byte[] bytes = Encoding.UTF8.GetBytes(p);
                oStream = new MemoryStream();
                oStream.Write(bytes, 0, bytes.Length);
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oStream;
        }
    }
}
