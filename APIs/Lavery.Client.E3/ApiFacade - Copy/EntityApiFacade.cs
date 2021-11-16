
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
    public class EntityApiFacade : Object
    {
        EntityApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public EntityApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new EntityApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCloneEntity
            returning E3EAPIEntityModelsEntityCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCloneResponse EntityCloneEntity(EntityCloneEntityRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCloneResponse oRet = default(E3EAPIEntityModelsEntityCloneResponse);
            try
            {
                oRet = oApi.EntityCloneEntity( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCloneEntityAsync
            returning E3EAPIEntityModelsEntityCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCloneResponse EntityCloneEntityAsync(EntityCloneEntityAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCloneResponse oRet = default(E3EAPIEntityModelsEntityCloneResponse);
            try
            {
                oRet = oApi.EntityCloneEntityAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCreateOrganization
            returning E3EAPIEntityModelsEntityCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCreateResponse EntityCreateOrganization(EntityCreateOrganizationRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCreateResponse oRet = default(E3EAPIEntityModelsEntityCreateResponse);
            try
            {
                oRet = oApi.EntityCreateOrganization( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCreateOrganizationAsync
            returning E3EAPIEntityModelsEntityCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCreateResponse EntityCreateOrganizationAsync(EntityCreateOrganizationAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCreateResponse oRet = default(E3EAPIEntityModelsEntityCreateResponse);
            try
            {
                oRet = oApi.EntityCreateOrganizationAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCreatePerson
            returning E3EAPIEntityModelsEntityCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCreateResponse EntityCreatePerson(EntityCreateOrganizationRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCreateResponse oRet = default(E3EAPIEntityModelsEntityCreateResponse);
            try
            {
                oRet = oApi.EntityCreatePerson( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityCreatePersonAsync
            returning E3EAPIEntityModelsEntityCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityCreateResponse EntityCreatePersonAsync(EntityCreateOrganizationAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityCreateResponse oRet = default(E3EAPIEntityModelsEntityCreateResponse);
            try
            {
                oRet = oApi.EntityCreatePersonAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityDeleteEntity
            returning E3EAPIEntityModelsEntityDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityDeleteResponse EntityDeleteEntity(EntityDeleteEntityRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityDeleteResponse oRet = default(E3EAPIEntityModelsEntityDeleteResponse);
            try
            {
                oRet = oApi.EntityDeleteEntity( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityDeleteRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityDeleteEntityAsync
            returning E3EAPIEntityModelsEntityDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityDeleteResponse EntityDeleteEntityAsync(EntityDeleteEntityAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityDeleteResponse oRet = default(E3EAPIEntityModelsEntityDeleteResponse);
            try
            {
                oRet = oApi.EntityDeleteEntityAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityDeleteRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetAllEntities
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetAllEntities(EntityGetAllEntitiesRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetAllEntities( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetAllEntitiesAsync
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetAllEntitiesAsync(EntityGetAllEntitiesAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetAllEntitiesAsync( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetNewOrganization
            returning E3EAPIEntityModelsEntityTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityTemplateResponse EntityGetNewOrganization(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityTemplateResponse oRet = default(E3EAPIEntityModelsEntityTemplateResponse);
            try
            {
                oRet = oApi.EntityGetNewOrganization( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetNewOrganizationAsync
            returning E3EAPIEntityModelsEntityTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityTemplateResponse EntityGetNewOrganizationAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityTemplateResponse oRet = default(E3EAPIEntityModelsEntityTemplateResponse);
            try
            {
                oRet = oApi.EntityGetNewOrganizationAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetNewPerson
            returning E3EAPIEntityModelsEntityTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityTemplateResponse EntityGetNewPerson(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityTemplateResponse oRet = default(E3EAPIEntityModelsEntityTemplateResponse);
            try
            {
                oRet = oApi.EntityGetNewPerson( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetNewPersonAsync
            returning E3EAPIEntityModelsEntityTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityTemplateResponse EntityGetNewPersonAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityTemplateResponse oRet = default(E3EAPIEntityModelsEntityTemplateResponse);
            try
            {
                oRet = oApi.EntityGetNewPersonAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetOrganizationSchema
            returning E3EAPIEntityModelsEntityGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetSchemaResponse EntityGetOrganizationSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetSchemaResponse oRet = default(E3EAPIEntityModelsEntityGetSchemaResponse);
            try
            {
                oRet = oApi.EntityGetOrganizationSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetOrganizationSchemaAsync
            returning E3EAPIEntityModelsEntityGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetSchemaResponse EntityGetOrganizationSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetSchemaResponse oRet = default(E3EAPIEntityModelsEntityGetSchemaResponse);
            try
            {
                oRet = oApi.EntityGetOrganizationSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetOrganizations
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetOrganizations(EntityGetAllEntitiesRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetOrganizations( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetOrganizationsAsync
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetOrganizationsAsync(EntityGetAllEntitiesAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetOrganizationsAsync( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetPersonSchema
            returning E3EAPIEntityModelsEntityGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetSchemaResponse EntityGetPersonSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetSchemaResponse oRet = default(E3EAPIEntityModelsEntityGetSchemaResponse);
            try
            {
                oRet = oApi.EntityGetPersonSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetPersonSchemaAsync
            returning E3EAPIEntityModelsEntityGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetSchemaResponse EntityGetPersonSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetSchemaResponse oRet = default(E3EAPIEntityModelsEntityGetSchemaResponse);
            try
            {
                oRet = oApi.EntityGetPersonSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetPersons
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetPersons(EntityGetAllEntitiesRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetPersons( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityGetPersonsAsync
            returning E3EAPIEntityModelsEntityGetRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetRequest EntityGetPersonsAsync(EntityGetAllEntitiesAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetRequest oRet = default(E3EAPIEntityModelsEntityGetRequest);
            try
            {
                oRet = oApi.EntityGetPersonsAsync( oClassRequestValue.entityId, oClassRequestValue.entityIndex, oClassRequestValue.displayName, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityModelFromEntities
            returning E3EAPIEntityModelsEntityGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetResponse EntityModelFromEntities(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetResponse oRet = default(E3EAPIEntityModelsEntityGetResponse);
            try
            {
                oRet = oApi.EntityModelFromEntities( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityModelFromEntitiesAsync
            returning E3EAPIEntityModelsEntityGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityGetResponse EntityModelFromEntitiesAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityGetResponse oRet = default(E3EAPIEntityModelsEntityGetResponse);
            try
            {
                oRet = oApi.EntityModelFromEntitiesAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityUpdateEntity
            returning E3EAPIEntityModelsEntityUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityUpdateResponse EntityUpdateEntity(EntityUpdateEntityRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityUpdateResponse oRet = default(E3EAPIEntityModelsEntityUpdateResponse);
            try
            {
                oRet = oApi.EntityUpdateEntity( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method EntityUpdateEntityAsync
            returning E3EAPIEntityModelsEntityUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIEntityModelsEntityUpdateResponse EntityUpdateEntityAsync(EntityUpdateEntityAsyncRequest oClassRequestValue)
        {
            E3EAPIEntityModelsEntityUpdateResponse oRet = default(E3EAPIEntityModelsEntityUpdateResponse);
            try
            {
                oRet = oApi.EntityUpdateEntityAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIEntityModelsEntityUpdateRequest, oClassRequestValue.cancellationToken).Result;
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