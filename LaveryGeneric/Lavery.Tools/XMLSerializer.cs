using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Lavery.Tools
{
    public class XMLSerializer<T>
    {

        public void SerializeToFile(T obj, XmlSerializerNamespaces ns, Encoding encoding, String sToFile)
        {
            try
            {
                String sStream = Serialize(obj, ns, encoding);
                using (StreamWriter writer = new StreamWriter(sToFile))
                {
                    writer.WriteLine(sStream);
                    Console.WriteLine("Serialze one envelopp to File {0}", sToFile);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public T DeserializeFromFile(String sFromFile)
        {
            T result = default(T);
            try
            {
                
                using (StreamReader reader = new StreamReader(sFromFile))
                {
                    result = Deserialize(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
            }
            return result;
        }

        public class StringWriterUtf8 : System.IO.StringWriter
        {
            public override Encoding Encoding
            {
                get
                {
                    return Encoding.UTF8;
                }
            }
        }
        public string Serialize(T obj, XmlSerializerNamespaces ns, Encoding encoding)
        {
            string result = string.Empty;
            /*
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;        // For cosmetic purposes.
            settings.IndentChars = "    "; // For cosmetic purposes.
            settings.Encoding = encoding;
            using (var xmlWriter = XmlWriter.Create(sb, settings))
            {   
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                serializer.Serialize(xmlWriter, obj, ns);
                result = xmlWriter.ToString();
            }
            */
            System.Xml.Serialization.XmlSerializer xml = new XmlSerializer(typeof(T));
            StringWriterUtf8 text = new StringWriterUtf8();
            xml.Serialize(text, obj, ns);
            return text.ToString();

            //return result;
        }

        /// <summary>
        ///  Deserializes the XML content to a specified object
        /// </summary>
        /// <param name="xml">
        /// <returns></returns>
        public T Deserialize(string xml)
        {
            T result = default(T);

            if (!string.IsNullOrEmpty(xml))
            {
                System.IO.TextReader tr = new System.IO.StringReader(xml);
                System.Xml.XmlReader reader = System.Xml.XmlReader.Create(tr);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

                if (serializer.CanDeserialize(reader))
                    result = (T)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
