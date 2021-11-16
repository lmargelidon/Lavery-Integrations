using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace Lavery.Events
{
    public  class EventEntryBase
    {
        //public  EventSerializerBase oEventSerializer = default(EventSerializerBase);
        public  class objectToBeSerialized
        {
            public Object oOriginalValue {get;set;}
            public Type tBdType {get;set;}
            public object oTargetValue {get;set;}
            public Boolean bLookUp {get;set;}
            public String sFkSchema {get;set;}
            public String sFkEntity {get;set;}
            public String sFkFilter {get;set;}

            public  objectToBeSerialized(Object oWithOriginalValue, Type tWithWithBdType, object oWithTargetValue,
                                            Boolean bWithLookUp, String sWithFkSchema, String sWithFkEntity, String sWithFkFilter)
            { 
            
            
                oOriginalValue  = oWithOriginalValue;
                tBdType         = tWithWithBdType;
                oTargetValue    = oWithTargetValue;
                bLookUp         = bWithLookUp;
                sFkSchema       = sWithFkSchema;
                sFkEntity       = sWithFkEntity;
                sFkFilter       = sWithFkFilter;
                        
            }
 
        }
        Dictionary<String, objectToBeSerialized> oDicoTobeSerialized = new Dictionary<string, objectToBeSerialized>();

        public Dictionary<String, objectToBeSerialized> ODicoTobeSerialized
        {
            get { return oDicoTobeSerialized; }
            
        }

        public  EventEntryBase(/*EventSerializerBase oWithSerialBase*/)
        {
                   
        }
        public void Add(String sWithKey, objectToBeSerialized oWithValue)
        {
            try
            {
                oDicoTobeSerialized.Add(sWithKey, oWithValue);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        

    }
}
