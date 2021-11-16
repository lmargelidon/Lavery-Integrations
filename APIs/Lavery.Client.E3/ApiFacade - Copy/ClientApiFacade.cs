
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Lavery.Client.E3
{
    [DataContract]
    public class ClientApiFacade : Object
    {
        ClientApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public ClientApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new ClientApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi"));           
            if (oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientCreateClient
            returning E3EAPIClientModelsClientCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientCreateResponse ClientCreateClient(ClientCreateClientRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientCreateResponse oRet = default(E3EAPIClientModelsClientCreateResponse);
            try
            {
                oRet = oApi.ClientCreateClient( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientCreateClientAsync
            returning E3EAPIClientModelsClientCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientCreateResponse ClientCreateClientAsync(ClientCreateClientAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientCreateResponse oRet = default(E3EAPIClientModelsClientCreateResponse);
            try
            {
                oRet = oApi.ClientCreateClientAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetClientSchema
            returning E3EAPIClientModelsClientGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetSchemaResponse ClientGetClientSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetSchemaResponse oRet = default(E3EAPIClientModelsClientGetSchemaResponse);
            try
            {
                oRet = oApi.ClientGetClientSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetClientSchemaAsync
            returning E3EAPIClientModelsClientGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetSchemaResponse ClientGetClientSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetSchemaResponse oRet = default(E3EAPIClientModelsClientGetSchemaResponse);
            try
            {
                oRet = oApi.ClientGetClientSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetClients
            returning E3EAPIClientModelsClientGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetResponse ClientGetClients(ClientGetClientsRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetResponse oRet = default(E3EAPIClientModelsClientGetResponse);
            try
            {
                oRet = oApi.ClientGetClients( oClassRequestValue.clientId, oClassRequestValue.clientIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetClientsAsync
            returning E3EAPIClientModelsClientGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetResponse ClientGetClientsAsync(ClientGetClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetResponse oRet = default(E3EAPIClientModelsClientGetResponse);
            try
            {
                oRet = oApi.ClientGetClientsAsync( oClassRequestValue.clientId, oClassRequestValue.clientIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetNewClient
            returning E3EAPIClientModelsClientTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientTemplateResponse ClientGetNewClient(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientTemplateResponse oRet = default(E3EAPIClientModelsClientTemplateResponse);
            try
            {
                oRet = oApi.ClientGetNewClient( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientGetNewClientAsync
            returning E3EAPIClientModelsClientTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientTemplateResponse ClientGetNewClientAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientTemplateResponse oRet = default(E3EAPIClientModelsClientTemplateResponse);
            try
            {
                oRet = oApi.ClientGetNewClientAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientModelFromClients
            returning E3EAPIClientModelsClientGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetResponse ClientModelFromClients(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetResponse oRet = default(E3EAPIClientModelsClientGetResponse);
            try
            {
                oRet = oApi.ClientModelFromClients( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientModelFromClientsAsync
            returning E3EAPIClientModelsClientGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientGetResponse ClientModelFromClientsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientGetResponse oRet = default(E3EAPIClientModelsClientGetResponse);
            try
            {
                oRet = oApi.ClientModelFromClientsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientUpdateClient
            returning E3EAPIClientModelsClientUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientUpdateResponse ClientUpdateClient(ClientUpdateClientRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientUpdateResponse oRet = default(E3EAPIClientModelsClientUpdateResponse);
            try
            {
                oRet = oApi.ClientUpdateClient( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientUpdateClientAsync
            returning E3EAPIClientModelsClientUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientUpdateResponse ClientUpdateClientAsync(ClientUpdateClientAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientUpdateResponse oRet = default(E3EAPIClientModelsClientUpdateResponse);
            try
            {
                oRet = oApi.ClientUpdateClientAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientValidateClients
            returning E3EAPIClientModelsClientValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientValidateResponse ClientValidateClients(ClientValidateClientsRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientValidateResponse oRet = default(E3EAPIClientModelsClientValidateResponse);
            try
            {
                oRet = oApi.ClientValidateClients( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method ClientValidateClientsAsync
            returning E3EAPIClientModelsClientValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIClientModelsClientValidateResponse ClientValidateClientsAsync(ClientValidateClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIClientModelsClientValidateResponse oRet = default(E3EAPIClientModelsClientValidateResponse);
            try
            {
                oRet = oApi.ClientValidateClientsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIClientModelsClientValidateRequest, oClassRequestValue.cancellationToken).Result;
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