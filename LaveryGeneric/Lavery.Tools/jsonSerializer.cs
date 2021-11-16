using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;


namespace Lavery.Tools
{
    public class jsonSerializer<I>
    {
        public jsonSerializer()
        { 
        }
        public I deserialize(String inputJson)
        {
            I outputObj;
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(inputJson)))
            {
                // Deserialization from JSON
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(I));
                outputObj = (I)deserializer.ReadObject(ms);
            }

            return outputObj;
        }
        public String serialize(Object inputObj)
        {
            
            DataContractJsonSerializer js = new DataContractJsonSerializer(inputObj.GetType());
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, inputObj);
            msObj.Position = 0;
            StreamReader sr = new StreamReader(msObj);

            // "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}"
            string json = sr.ReadToEnd();

            sr.Close();
            msObj.Close();
            return json;
        }

    }
}
