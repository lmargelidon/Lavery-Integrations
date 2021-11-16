using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Lavery.Tools.XML
{
    public class SerializeMessage
    {
        public static String serialize<T>(T oWithMessageClass)
        {
            String sRet = default(String);
            try
            {
                StringBuilder builder = new System.Text.StringBuilder();
                XmlSerializer su = new XmlSerializer(typeof(T));
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                using (var writer = System.Xml.XmlWriter.Create(builder))
                {
                    su.Serialize(writer, oWithMessageClass, ns);
                }
                sRet = builder.ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return sRet;

        }
        public static Boolean derialize<T>(ref T oWithMessageClass, String sWithClassSerialisation)
        {
            Boolean bRet = true;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                using (XmlReader reader = XmlReader.Create(new StringReader(sWithClassSerialisation)))
                {
                    oWithMessageClass = (T)ser.Deserialize(reader);
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;

        }
        public static Boolean derialize<T>(ref T oWithMessageClass, XmlDocument oWithClassSerialisation)
        {
            Boolean bRet = true;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                oWithMessageClass = (T)ser.Deserialize(new StringReader(oWithClassSerialisation.OuterXml));
                /*
                using (XmlReader reader = XmlReader.Create(new StringReader(sWithClassSerialisation)))
                {
                    oWithMessageClass = (T)ser.Deserialize(reader);
                }
                    */

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;

        }
      
    }
}
