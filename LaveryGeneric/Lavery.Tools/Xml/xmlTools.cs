using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Lavery.Tools.Xml
{
    public class xmlTools
    {
        static Dictionary<String, String> EscapeSequenceReplace = new Dictionary<string, string>()
             {   {"'","''"},
                 {"&"," "}
             };
        public static string normalizeDocumentBeforeParsing(String sWithXml)
        {
            String sRet = sWithXml;
            try
            {
                foreach (KeyValuePair<String, String> pair in EscapeSequenceReplace)
                {
                    sRet = sRet.Replace(pair.Key, pair.Value);
                }

            }
            catch { }
            return sRet;
        }
        static public String ToString(XmlDocument oWithDoc)
        {
            String sRet = "";
            try
            {
                StringWriter sWriter = new StringWriter();
                XmlTextWriter xmlTextWriter = new XmlTextWriter(sWriter);
                oWithDoc.WriteTo(xmlTextWriter);
                sRet = sWriter.ToString();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return sRet;
        }
        /*
              * Possible Exceptions:
              *  System.ArgumentException
              *  System.ArgumentNullException
              *  System.InvalidOperationException
              *  System.IO.DirectoryNotFoundException
              *  System.IO.FileNotFoundException
              *  System.IO.IOException
              *  System.IO.PathTooLongException
              *  System.NotSupportedException
              *  System.Security.SecurityException
              *  System.UnauthorizedAccessException
              *  System.UriFormatException
              *  System.Xml.XmlException
              *  System.Xml.XPath.XPathException
          */
        /*
         * 
        static public void changeXMLElementValue(XmlDocument oWithDoc, string sWithSelectElement, string sWithNewValue)
        {
            try
            {
                XmlNode node = oWithDoc.SelectSingleNode(sWithSelectElement); //"/MyXmlType/" + element);
                if (node != null)
                {
                    node.InnerText = sWithNewValue;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
          
            }
        }
        */
        /*
        static public void changeXMLElementValue(XmlDocument oWithDoc, string sWithSelectElement, string sWithNewValue)
        {
            try
            {
                XmlNode oWNode = oWithDoc.SelectSingleNode(sWithSelectElement); //"/MyXmlType/" + element);

                if (oWNode == null)
                { 
                    char[] sSep = new char[1];
                    sSep[0] = '/';
                    String[] sTokenCS = sWithSelectElement.Split(sSep);
                    if (sTokenCS.Length > 0)
                    {   
                        XmlNode oWNodeInter = null;
                        foreach (String sSubString in sTokenCS)
                        {
                            if (sSubString.Length > 0)
                            {
                                if (oWNode != null)
                                {
                                    oWNodeInter = oWNode.SelectSingleNode(sSubString);
                                    if (oWNodeInter == null)
                                    {
                                        oWNodeInter = oWithDoc.CreateNode(XmlNodeType.Element, sSubString, "");
                                        oWNode.AppendChild(oWNodeInter);
                                    }
                                    oWNode = oWNodeInter;
                                }
                                else
                                {
                                    oWNodeInter = oWithDoc.SelectSingleNode(sSubString);
                                    if (oWNodeInter == null)
                                    {
                                        oWNodeInter = oWithDoc.CreateNode(XmlNodeType.Element, sSubString, "");
                                        oWithDoc.AppendChild(oWNodeInter);
                                    }
                                    oWNode = oWNodeInter;
                                }

                            }

                        }
                    }

                }

                if (oWNode != null)
                {
                    oWNode.InnerText = sWithNewValue;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
                
            }
        }
         * */
        static public void changeXMLElementValue(XmlDocument oWithDoc, string sWithSelectElement, string sWithNewValue/*, Boolean bWithAddChildIfNotFound*/)
        {
            try
            {
                XmlNode oWNode = oWithDoc.SelectSingleNode(sWithSelectElement); //"/MyXmlType/" + element);

                if (oWNode == null)
                {
                    char[] sSep = new char[1];
                    sSep[0] = '/';
                    String[] sTokenCS = sWithSelectElement.Split(sSep);
                    if (sTokenCS.Length > 0)
                    {
                        XmlNode oWNodeInter = null;
                        foreach (String sSubString in sTokenCS)
                        {
                            if (sSubString.Length > 0)
                            {
                                if (oWNode != null)
                                {
                                    oWNodeInter = oWNode.SelectSingleNode(sSubString);
                                    if (oWNodeInter == null)
                                    {
                                        oWNodeInter = oWithDoc.CreateNode(XmlNodeType.Element, sSubString, "");
                                        oWNode.AppendChild(oWNodeInter);
                                    }
                                    oWNode = oWNodeInter;
                                }
                                else
                                {
                                    oWNodeInter = oWithDoc.SelectSingleNode(sSubString);
                                    if (oWNodeInter == null)
                                    {
                                        oWNodeInter = oWithDoc.CreateNode(XmlNodeType.Element, sSubString, "");
                                        oWithDoc.AppendChild(oWNodeInter);
                                    }
                                    oWNode = oWNodeInter;
                                }

                            }

                        }
                    }

                }

                if (oWNode != null)
                {
                    oWNode.InnerText = sWithNewValue;
                }
            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }
        static public String getXMLElementValue(XmlDocument oWithDoc, string sWithSelectElement)
        {
            String sRet = "";
            try
            {
                XmlNode node = oWithDoc.SelectSingleNode(sWithSelectElement); //"/MyXmlType/" + element);
                if (node != null)
                {
                    sRet = node.InnerText;
                }
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            return sRet;
        }
        static public String getXMLElementValue(XmlNode oWithNode, string sWithSelectElement)
        {
            String sRet = "";
            try
            {
                XmlNode node = oWithNode.SelectSingleNode(sWithSelectElement); //"/MyXmlType/" + element);
                if (node != null)
                {
                    sRet = node.InnerText;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return sRet;
        }
        public static string TransformXMLToHTML(string inputXml, string xsltString)
        {
            XslCompiledTransform transform = GetAndCacheTransform(xsltString);
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(inputXml)))
            {
                transform.Transform(reader, null, results);
            }
            return results.ToString();
        }

        private static Dictionary<String, XslCompiledTransform> cachedTransforms = new Dictionary<string, XslCompiledTransform>();
        private static XslCompiledTransform GetAndCacheTransform(String xslt)
        {
            XslCompiledTransform transform;
            if (!cachedTransforms.TryGetValue(xslt, out transform))
            {
                transform = new XslCompiledTransform();
                using (XmlReader reader = XmlReader.Create(new StringReader(xslt)))
                {
                    transform.Load(reader);
                }
                cachedTransforms.Add(xslt, transform);
            }
            return transform;
        }
    }
}
