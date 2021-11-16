
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;

using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Lavery.Client.E3
{
    [DataContract]
    public class TimekeeperApiFacade : Object
    {
        TimekeeperApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public TimekeeperApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new TimekeeperApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperCreateTimekeeper
            returning E3EAPITimekeeperModelsTimekeeperCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperCreateResponse TimekeeperCreateTimekeeper(TimekeeperCreateTimekeeperRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperCreateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperCreateResponse);
            try
            {
                oRet = oApi.TimekeeperCreateTimekeeper( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperCreateTimekeeperAsync
            returning E3EAPITimekeeperModelsTimekeeperCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperCreateResponse TimekeeperCreateTimekeeperAsync(TimekeeperCreateTimekeeperAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperCreateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperCreateResponse);
            try
            {
                oRet = oApi.TimekeeperCreateTimekeeperAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetNewTimekeeper
            returning E3EAPITimekeeperModelsTimekeeperTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperTemplateResponse TimekeeperGetNewTimekeeper(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperTemplateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperTemplateResponse);
            try
            {
                oRet = oApi.TimekeeperGetNewTimekeeper( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetNewTimekeeperAsync
            returning E3EAPITimekeeperModelsTimekeeperTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperTemplateResponse TimekeeperGetNewTimekeeperAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperTemplateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperTemplateResponse);
            try
            {
                oRet = oApi.TimekeeperGetNewTimekeeperAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetTimekeeperSchema
            returning E3EAPITimekeeperModelsTimekeeperGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetSchemaResponse TimekeeperGetTimekeeperSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetSchemaResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetSchemaResponse);
            try
            {
                oRet = oApi.TimekeeperGetTimekeeperSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetTimekeeperSchemaAsync
            returning E3EAPITimekeeperModelsTimekeeperGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetSchemaResponse TimekeeperGetTimekeeperSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetSchemaResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetSchemaResponse);
            try
            {
                oRet = oApi.TimekeeperGetTimekeeperSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetTimekeepers
            returning E3EAPITimekeeperModelsTimekeeperGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetResponse TimekeeperGetTimekeepers(TimekeeperGetTimekeepersRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetResponse);
            try
            {
                oRet = oApi.TimekeeperGetTimekeepers( oClassRequestValue.timekeeperId, oClassRequestValue.timekeeperIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperGetTimekeepersAsync
            returning E3EAPITimekeeperModelsTimekeeperGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetResponse TimekeeperGetTimekeepersAsync(TimekeeperGetTimekeepersAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetResponse);
            try
            {
                oRet = oApi.TimekeeperGetTimekeepersAsync( oClassRequestValue.timekeeperId, oClassRequestValue.timekeeperIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperModelFromTimekeepers
            returning E3EAPITimekeeperModelsTimekeeperGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetResponse TimekeeperModelFromTimekeepers(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetResponse);
            try
            {
                oRet = oApi.TimekeeperModelFromTimekeepers( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperModelFromTimekeepersAsync
            returning E3EAPITimekeeperModelsTimekeeperGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperGetResponse TimekeeperModelFromTimekeepersAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperGetResponse oRet = default(E3EAPITimekeeperModelsTimekeeperGetResponse);
            try
            {
                oRet = oApi.TimekeeperModelFromTimekeepersAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperUpdateTimekeeper
            returning E3EAPITimekeeperModelsTimekeeperUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperUpdateResponse TimekeeperUpdateTimekeeper(TimekeeperUpdateTimekeeperRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperUpdateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperUpdateResponse);
            try
            {
                oRet = oApi.TimekeeperUpdateTimekeeper( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperUpdateTimekeeperAsync
            returning E3EAPITimekeeperModelsTimekeeperUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperUpdateResponse TimekeeperUpdateTimekeeperAsync(TimekeeperUpdateTimekeeperAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperUpdateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperUpdateResponse);
            try
            {
                oRet = oApi.TimekeeperUpdateTimekeeperAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperValidateTimekeepers
            returning E3EAPITimekeeperModelsTimekeeperValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperValidateResponse TimekeeperValidateTimekeepers(TimekeeperValidateTimekeepersRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperValidateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperValidateResponse);
            try
            {
                oRet = oApi.TimekeeperValidateTimekeepers( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimekeeperValidateTimekeepersAsync
            returning E3EAPITimekeeperModelsTimekeeperValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimekeeperModelsTimekeeperValidateResponse TimekeeperValidateTimekeepersAsync(TimekeeperValidateTimekeepersAsyncRequest oClassRequestValue)
        {
            E3EAPITimekeeperModelsTimekeeperValidateResponse oRet = default(E3EAPITimekeeperModelsTimekeeperValidateResponse);
            try
            {
                oRet = oApi.TimekeeperValidateTimekeepersAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimekeeperModelsTimekeeperValidateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }
    }
}