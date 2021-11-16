
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
    public class CostApiFacade : Object
    {
        CostApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public CostApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new CostApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostCreatePendingCostCard
            returning E3EAPICostModelsCostCardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardCreateResponse CostCreatePendingCostCard(CostCreatePendingCostCardRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardCreateResponse oRet = default(E3EAPICostModelsCostCardCreateResponse);
            try
            {
                oRet = oApi.CostCreatePendingCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostCreatePendingCostCardAsync
            returning E3EAPICostModelsCostCardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardCreateResponse CostCreatePendingCostCardAsync(CostCreatePendingCostCardAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardCreateResponse oRet = default(E3EAPICostModelsCostCardCreateResponse);
            try
            {
                oRet = oApi.CostCreatePendingCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostCreatePostedCostCard
            returning E3EAPICostModelsCostCardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardCreateResponse CostCreatePostedCostCard(CostCreatePendingCostCardRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardCreateResponse oRet = default(E3EAPICostModelsCostCardCreateResponse);
            try
            {
                oRet = oApi.CostCreatePostedCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostCreatePostedCostCardAsync
            returning E3EAPICostModelsCostCardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardCreateResponse CostCreatePostedCostCardAsync(CostCreatePendingCostCardAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardCreateResponse oRet = default(E3EAPICostModelsCostCardCreateResponse);
            try
            {
                oRet = oApi.CostCreatePostedCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetNewPendingCostCard
            returning E3EAPICostModelsCostCardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardTemplateResponse CostGetNewPendingCostCard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardTemplateResponse oRet = default(E3EAPICostModelsCostCardTemplateResponse);
            try
            {
                oRet = oApi.CostGetNewPendingCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetNewPendingCostCardAsync
            returning E3EAPICostModelsCostCardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardTemplateResponse CostGetNewPendingCostCardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardTemplateResponse oRet = default(E3EAPICostModelsCostCardTemplateResponse);
            try
            {
                oRet = oApi.CostGetNewPendingCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetNewPostedCostCard
            returning E3EAPICostModelsCostCardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardTemplateResponse CostGetNewPostedCostCard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardTemplateResponse oRet = default(E3EAPICostModelsCostCardTemplateResponse);
            try
            {
                oRet = oApi.CostGetNewPostedCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetNewPostedCostCardAsync
            returning E3EAPICostModelsCostCardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardTemplateResponse CostGetNewPostedCostCardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardTemplateResponse oRet = default(E3EAPICostModelsCostCardTemplateResponse);
            try
            {
                oRet = oApi.CostGetNewPostedCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPendingCostCardSchema
            returning E3EAPICostModelsCostCardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetSchemaResponse CostGetPendingCostCardSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetSchemaResponse oRet = default(E3EAPICostModelsCostCardGetSchemaResponse);
            try
            {
                oRet = oApi.CostGetPendingCostCardSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPendingCostCardSchemaAsync
            returning E3EAPICostModelsCostCardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetSchemaResponse CostGetPendingCostCardSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetSchemaResponse oRet = default(E3EAPICostModelsCostCardGetSchemaResponse);
            try
            {
                oRet = oApi.CostGetPendingCostCardSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPendingCostCards
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostGetPendingCostCards(CostGetPendingCostCardsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostGetPendingCostCards( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.costcardID, oClassRequestValue.costPeindIndex, oClassRequestValue.costType, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.matterIndex, oClassRequestValue.matterNumber, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPendingCostCardsAsync
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostGetPendingCostCardsAsync(CostGetPendingCostCardsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostGetPendingCostCardsAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.costcardID, oClassRequestValue.costPeindIndex, oClassRequestValue.costType, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.matterIndex, oClassRequestValue.matterNumber, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPostedCostCardSchema
            returning E3EAPICostModelsCostCardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetSchemaResponse CostGetPostedCostCardSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetSchemaResponse oRet = default(E3EAPICostModelsCostCardGetSchemaResponse);
            try
            {
                oRet = oApi.CostGetPostedCostCardSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPostedCostCardSchemaAsync
            returning E3EAPICostModelsCostCardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetSchemaResponse CostGetPostedCostCardSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetSchemaResponse oRet = default(E3EAPICostModelsCostCardGetSchemaResponse);
            try
            {
                oRet = oApi.CostGetPostedCostCardSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPostedCostCards
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostGetPostedCostCards(CostGetPostedCostCardsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostGetPostedCostCards( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.costcardID, oClassRequestValue.costIndex, oClassRequestValue.costType, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.matterIndex, oClassRequestValue.matterNumber, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostGetPostedCostCardsAsync
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostGetPostedCostCardsAsync(CostGetPostedCostCardsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostGetPostedCostCardsAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.costcardID, oClassRequestValue.costIndex, oClassRequestValue.costType, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.matterIndex, oClassRequestValue.matterNumber, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostModelFromPendingCostCards
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostModelFromPendingCostCards(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostModelFromPendingCostCards( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostModelFromPendingCostCardsAsync
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostModelFromPendingCostCardsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostModelFromPendingCostCardsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostModelFromPostedCostCards
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostModelFromPostedCostCards(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostModelFromPostedCostCards( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostModelFromPostedCostCardsAsync
            returning E3EAPICostModelsCostCardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardGetResponse CostModelFromPostedCostCardsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardGetResponse oRet = default(E3EAPICostModelsCostCardGetResponse);
            try
            {
                oRet = oApi.CostModelFromPostedCostCardsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostUpdatePendingCostCard
            returning E3EAPICostModelsCostCardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardUpdateResponse CostUpdatePendingCostCard(CostUpdatePendingCostCardRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardUpdateResponse oRet = default(E3EAPICostModelsCostCardUpdateResponse);
            try
            {
                oRet = oApi.CostUpdatePendingCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostUpdatePendingCostCardAsync
            returning E3EAPICostModelsCostCardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardUpdateResponse CostUpdatePendingCostCardAsync(CostUpdatePendingCostCardAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardUpdateResponse oRet = default(E3EAPICostModelsCostCardUpdateResponse);
            try
            {
                oRet = oApi.CostUpdatePendingCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostUpdatePostedCostCard
            returning E3EAPICostModelsCostCardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardUpdateResponse CostUpdatePostedCostCard(CostUpdatePendingCostCardRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardUpdateResponse oRet = default(E3EAPICostModelsCostCardUpdateResponse);
            try
            {
                oRet = oApi.CostUpdatePostedCostCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostUpdatePostedCostCardAsync
            returning E3EAPICostModelsCostCardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardUpdateResponse CostUpdatePostedCostCardAsync(CostUpdatePendingCostCardAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardUpdateResponse oRet = default(E3EAPICostModelsCostCardUpdateResponse);
            try
            {
                oRet = oApi.CostUpdatePostedCostCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostValidatePendingCostCards
            returning E3EAPICostModelsCostCardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardValidateResponse CostValidatePendingCostCards(CostValidatePendingCostCardsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardValidateResponse oRet = default(E3EAPICostModelsCostCardValidateResponse);
            try
            {
                oRet = oApi.CostValidatePendingCostCards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostValidatePendingCostCardsAsync
            returning E3EAPICostModelsCostCardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardValidateResponse CostValidatePendingCostCardsAsync(CostValidatePendingCostCardsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardValidateResponse oRet = default(E3EAPICostModelsCostCardValidateResponse);
            try
            {
                oRet = oApi.CostValidatePendingCostCardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardValidateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostValidatePostedCostCards
            returning E3EAPICostModelsCostCardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardValidateResponse CostValidatePostedCostCards(CostValidatePendingCostCardsRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardValidateResponse oRet = default(E3EAPICostModelsCostCardValidateResponse);
            try
            {
                oRet = oApi.CostValidatePostedCostCards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method CostValidatePostedCostCardsAsync
            returning E3EAPICostModelsCostCardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPICostModelsCostCardValidateResponse CostValidatePostedCostCardsAsync(CostValidatePendingCostCardsAsyncRequest oClassRequestValue)
        {
            E3EAPICostModelsCostCardValidateResponse oRet = default(E3EAPICostModelsCostCardValidateResponse);
            try
            {
                oRet = oApi.CostValidatePostedCostCardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPICostModelsCostCardValidateRequest, oClassRequestValue.cancellationToken).Result;
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