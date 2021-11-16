
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
    public class RelatedPartyApiFacade : Object
    {
        RelatedPartyApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public RelatedPartyApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new RelatedPartyApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyCreateRelatedParty
            returning E3EAPIRelatedPartyModelsRelatedPartyCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyCreateResponse RelatedPartyCreateRelatedParty(RelatedPartyCreateRelatedPartyRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyCreateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyCreateResponse);
            try
            {
                oRet = oApi.RelatedPartyCreateRelatedParty( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyCreateRelatedPartyAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyCreateResponse RelatedPartyCreateRelatedPartyAsync(RelatedPartyCreateRelatedPartyAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyCreateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyCreateResponse);
            try
            {
                oRet = oApi.RelatedPartyCreateRelatedPartyAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetNewRelatedParty
            returning E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse RelatedPartyGetNewRelatedParty(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse);
            try
            {
                oRet = oApi.RelatedPartyGetNewRelatedParty( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetNewRelatedPartyAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse RelatedPartyGetNewRelatedPartyAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyTemplateResponse);
            try
            {
                oRet = oApi.RelatedPartyGetNewRelatedPartyAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetRelatedParties
            returning E3EAPIRelatedPartyModelsRelatedPartyGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetResponse RelatedPartyGetRelatedParties(RelatedPartyGetRelatedPartiesRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetResponse);
            try
            {
                oRet = oApi.RelatedPartyGetRelatedParties( oClassRequestValue.relatedPartyId, oClassRequestValue.relatedPartyIndex, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetRelatedPartiesAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetResponse RelatedPartyGetRelatedPartiesAsync(RelatedPartyGetRelatedPartiesAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetResponse);
            try
            {
                oRet = oApi.RelatedPartyGetRelatedPartiesAsync( oClassRequestValue.relatedPartyId, oClassRequestValue.relatedPartyIndex, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetRelatedPartySchema
            returning E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse RelatedPartyGetRelatedPartySchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse);
            try
            {
                oRet = oApi.RelatedPartyGetRelatedPartySchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyGetRelatedPartySchemaAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse RelatedPartyGetRelatedPartySchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetSchemaResponse);
            try
            {
                oRet = oApi.RelatedPartyGetRelatedPartySchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyModelFromRelatedParties
            returning E3EAPIRelatedPartyModelsRelatedPartyGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetResponse RelatedPartyModelFromRelatedParties(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetResponse);
            try
            {
                oRet = oApi.RelatedPartyModelFromRelatedParties( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyModelFromRelatedPartiesAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyGetResponse RelatedPartyModelFromRelatedPartiesAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyGetResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyGetResponse);
            try
            {
                oRet = oApi.RelatedPartyModelFromRelatedPartiesAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyUpdateRelatedParty
            returning E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse RelatedPartyUpdateRelatedParty(RelatedPartyUpdateRelatedPartyRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse);
            try
            {
                oRet = oApi.RelatedPartyUpdateRelatedParty( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyUpdateRelatedPartyAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse RelatedPartyUpdateRelatedPartyAsync(RelatedPartyUpdateRelatedPartyAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyUpdateResponse);
            try
            {
                oRet = oApi.RelatedPartyUpdateRelatedPartyAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyValidateRelatedParties
            returning E3EAPIRelatedPartyModelsRelatedPartyValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyValidateResponse RelatedPartyValidateRelatedParties(RelatedPartyValidateRelatedPartiesRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyValidateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyValidateResponse);
            try
            {
                oRet = oApi.RelatedPartyValidateRelatedParties( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method RelatedPartyValidateRelatedPartiesAsync
            returning E3EAPIRelatedPartyModelsRelatedPartyValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIRelatedPartyModelsRelatedPartyValidateResponse RelatedPartyValidateRelatedPartiesAsync(RelatedPartyValidateRelatedPartiesAsyncRequest oClassRequestValue)
        {
            E3EAPIRelatedPartyModelsRelatedPartyValidateResponse oRet = default(E3EAPIRelatedPartyModelsRelatedPartyValidateResponse);
            try
            {
                oRet = oApi.RelatedPartyValidateRelatedPartiesAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIRelatedPartyModelsRelatedPartyValidateRequest, oClassRequestValue.cancellationToken).Result;
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