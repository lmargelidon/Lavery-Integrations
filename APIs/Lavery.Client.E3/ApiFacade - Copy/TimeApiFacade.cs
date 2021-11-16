
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
    public class TimeApiFacade : Object
    {
        TimeApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public TimeApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new TimeApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdateTimeCaptureModelAsync
            returning E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse TimeUpdateTimeCaptureModelAsync(TimeUpdateTimeCaptureModelAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdateTimeCaptureModelAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidatePendingTimecards
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidatePendingTimecards(TimeValidatePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidatePendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidatePendingTimecardsAsync
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidatePendingTimecardsAsync(TimeValidatePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidatePendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidatePostedTimecards
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidatePostedTimecards(TimeValidatePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidatePostedTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidatePostedTimecardsAsync
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidatePostedTimecardsAsync(TimeValidatePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidatePostedTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidateTimecaptureCard
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidateTimecaptureCard(TimeValidatePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidateTimecaptureCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeValidateTimecaptureCardAsync
            returning E3EAPITimeModelsTimecardValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardValidateResponse TimeValidateTimecaptureCardAsync(TimeValidatePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardValidateResponse oRet = default(E3EAPITimeModelsTimecardValidateResponse);
            try
            {
                oRet = oApi.TimeValidateTimecaptureCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardValidateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewPostedTimecard
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPostedTimecard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewPostedTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewPostedTimecardAsync
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPostedTimecardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewPostedTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewTimeCaptureCard
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewTimeCaptureCard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewTimeCaptureCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewTimeCaptureCardAsync
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewTimeCaptureCardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewTimeCaptureCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPendingTimecardSchema
            returning E3EAPITimeModelsTimecardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPendingTimecardSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetSchemaResponse oRet = default(E3EAPITimeModelsTimecardGetSchemaResponse);
            try
            {
                oRet = oApi.TimeGetPendingTimecardSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPendingTimecardSchemaAsync
            returning E3EAPITimeModelsTimecardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPendingTimecardSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetSchemaResponse oRet = default(E3EAPITimeModelsTimecardGetSchemaResponse);
            try
            {
                oRet = oApi.TimeGetPendingTimecardSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPendingTimecards
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetPendingTimecards(TimeGetPendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetPendingTimecards( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timeCardPendingID, oClassRequestValue.timePendIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetPendingTimecardsAsync(TimeGetPendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetPendingTimecardsAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timeCardPendingID, oClassRequestValue.timePendIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPostedTimecardSchema
            returning E3EAPITimeModelsTimecardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPostedTimecardSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetSchemaResponse oRet = default(E3EAPITimeModelsTimecardGetSchemaResponse);
            try
            {
                oRet = oApi.TimeGetPostedTimecardSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPostedTimecardSchemaAsync
            returning E3EAPITimeModelsTimecardGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPostedTimecardSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetSchemaResponse oRet = default(E3EAPITimeModelsTimecardGetSchemaResponse);
            try
            {
                oRet = oApi.TimeGetPostedTimecardSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPostedTimecards
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetPostedTimecards(TimeGetPostedTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetPostedTimecards( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timecardID, oClassRequestValue.timeIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetPostedTimecardsAsync
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetPostedTimecardsAsync(TimeGetPostedTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetPostedTimecardsAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timecardID, oClassRequestValue.timeIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCaptureAllCards
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeGetTimeCaptureAllCards(TimeGetTimeCaptureAllCardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeGetTimeCaptureAllCards( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCaptureAllCardsAsync
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeGetTimeCaptureAllCardsAsync(TimeGetTimeCaptureAllCardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeGetTimeCaptureAllCardsAsync( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCaptureModels
            returning E3EAPIDataObjectModelModelsDataObjectModelGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelGetResponse TimeGetTimeCaptureModels(TimeGetTimeCaptureModelsRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelGetResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelGetResponse);
            try
            {
                oRet = oApi.TimeGetTimeCaptureModels( oClassRequestValue.modelId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCaptureModelsAsync
            returning E3EAPIDataObjectModelModelsDataObjectModelGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelGetResponse TimeGetTimeCaptureModelsAsync(TimeGetTimeCaptureModelsAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelGetResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelGetResponse);
            try
            {
                oRet = oApi.TimeGetTimeCaptureModelsAsync( oClassRequestValue.modelId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCapturePendingCards
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetTimeCapturePendingCards(TimeGetPendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetTimeCapturePendingCards( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timeCardPendingID, oClassRequestValue.timePendIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimeCapturePendingCardsAsync
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeGetTimeCapturePendingCardsAsync(TimeGetPendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeGetTimeCapturePendingCardsAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timeCardPendingID, oClassRequestValue.timePendIndex, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimecards
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeGetTimecards(TimeGetTimeCaptureAllCardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeGetTimecards( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimecardsAsync
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeGetTimecardsAsync(TimeGetTimeCaptureAllCardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeGetTimecardsAsync( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimecardsGroupedByDay
            returning E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse TimeGetTimecardsGroupedByDay(TimeGetTimecardsGroupedByDayRequest oClassRequestValue)
        {
            E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse oRet = default(E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse);
            try
            {
                oRet = oApi.TimeGetTimecardsGroupedByDay( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.lastDays, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.mattIndex, oClassRequestValue.clientIndex, oClassRequestValue.attributesToInclude, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetTimecardsGroupedByDayAsync
            returning E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse TimeGetTimecardsGroupedByDayAsync(TimeGetTimecardsGroupedByDayAsyncRequest oClassRequestValue)
        {
            E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse oRet = default(E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse);
            try
            {
                oRet = oApi.TimeGetTimecardsGroupedByDayAsync( oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.lastDays, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.mattIndex, oClassRequestValue.clientIndex, oClassRequestValue.attributesToInclude, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeModelFromPendingTimecards
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeModelFromPendingTimecards(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeModelFromPendingTimecards( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeModelFromPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeModelFromPendingTimecardsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeModelFromPendingTimecardsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeModelFromPostedTimecards
            returning E3EAPIDataObjectModelsDataObjectGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelsDataObjectGetResponse TimeModelFromPostedTimecards(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelsDataObjectGetResponse oRet = default(E3EAPIDataObjectModelsDataObjectGetResponse);
            try
            {
                oRet = oApi.TimeModelFromPostedTimecards( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeModelFromPostedTimecardsAsync
            returning E3EAPIDataObjectModelsDataObjectGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelsDataObjectGetResponse TimeModelFromPostedTimecardsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelsDataObjectGetResponse oRet = default(E3EAPIDataObjectModelsDataObjectGetResponse);
            try
            {
                oRet = oApi.TimeModelFromPostedTimecardsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimePostPendingTimecards
            returning E3EAPITimeModelsTimecardPostResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardPostResponse TimePostPendingTimecards(TimePostPendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardPostResponse oRet = default(E3EAPITimeModelsTimecardPostResponse);
            try
            {
                oRet = oApi.TimePostPendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardPostRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimePostPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardPostResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardPostResponse TimePostPendingTimecardsAsync(TimePostPendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardPostResponse oRet = default(E3EAPITimeModelsTimecardPostResponse);
            try
            {
                oRet = oApi.TimePostPendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardPostRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeQueryTimeCaptureAllCards
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeQueryTimeCaptureAllCards(TimeQueryTimeCaptureAllCardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeQueryTimeCaptureAllCards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardGetRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeQueryTimeCaptureAllCardsAsync
            returning E3EAPITimeModelsTimecardGetAllResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetAllResponse TimeQueryTimeCaptureAllCardsAsync(TimeQueryTimeCaptureAllCardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetAllResponse oRet = default(E3EAPITimeModelsTimecardGetAllResponse);
            try
            {
                oRet = oApi.TimeQueryTimeCaptureAllCardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardGetRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeQueryTimeCapturePendingCards
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeQueryTimeCapturePendingCards(TimeQueryTimeCaptureAllCardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeQueryTimeCapturePendingCards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardGetRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeQueryTimeCapturePendingCardsAsync
            returning E3EAPITimeModelsTimecardGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardGetResponse TimeQueryTimeCapturePendingCardsAsync(TimeQueryTimeCaptureAllCardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardGetResponse oRet = default(E3EAPITimeModelsTimecardGetResponse);
            try
            {
                oRet = oApi.TimeQueryTimeCapturePendingCardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardGetRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeSpellcheckPendingTimecards
            returning E3EAPITimeModelsTimecardSpellCheckResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardSpellCheckResponse TimeSpellcheckPendingTimecards(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardSpellCheckResponse oRet = default(E3EAPITimeModelsTimecardSpellCheckResponse);
            try
            {
                oRet = oApi.TimeSpellcheckPendingTimecards( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeSpellcheckPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardSpellCheckResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardSpellCheckResponse TimeSpellcheckPendingTimecardsAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardSpellCheckResponse oRet = default(E3EAPITimeModelsTimecardSpellCheckResponse);
            try
            {
                oRet = oApi.TimeSpellcheckPendingTimecardsAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeStartStopTimer
            returning E3EAPITimeModelsStartStopTimerResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsStartStopTimerResponse TimeStartStopTimer(TimeStartStopTimerRequest oClassRequestValue)
        {
            E3EAPITimeModelsStartStopTimerResponse oRet = default(E3EAPITimeModelsStartStopTimerResponse);
            try
            {
                oRet = oApi.TimeStartStopTimer( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsStartStopTimerRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeStartStopTimerAsync
            returning E3EAPITimeModelsStartStopTimerResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsStartStopTimerResponse TimeStartStopTimerAsync(TimeStartStopTimerAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsStartStopTimerResponse oRet = default(E3EAPITimeModelsStartStopTimerResponse);
            try
            {
                oRet = oApi.TimeStartStopTimerAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsStartStopTimerRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdatePendingTimecard
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePendingTimecard(TimeUpdatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdatePendingTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdatePendingTimecardAsync
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePendingTimecardAsync(TimeUpdatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdatePendingTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdatePostedTimecard
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePostedTimecard(TimeUpdatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdatePostedTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdatePostedTimecardAsync
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePostedTimecardAsync(TimeUpdatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdatePostedTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdateTimeCaptureCard
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdateTimeCaptureCard(TimeUpdatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdateTimeCaptureCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdateTimeCaptureCardAsync
            returning E3EAPITimeModelsTimecardUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardUpdateResponse TimeUpdateTimeCaptureCardAsync(TimeUpdatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardUpdateResponse oRet = default(E3EAPITimeModelsTimecardUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdateTimeCaptureCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeUpdateTimeCaptureModel
            returning E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse TimeUpdateTimeCaptureModel(TimeUpdateTimeCaptureModelRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse);
            try
            {
                oRet = oApi.TimeUpdateTimeCaptureModel( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeAddPendingTimecard
            returning E3EAPITimeModelsTimecardAddResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardAddResponse TimeAddPendingTimecard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardAddResponse oRet = default(E3EAPITimeModelsTimecardAddResponse);
            try
            {
                oRet = oApi.TimeAddPendingTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeAddPendingTimecardAsync
            returning E3EAPITimeModelsTimecardAddResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardAddResponse TimeAddPendingTimecardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardAddResponse oRet = default(E3EAPITimeModelsTimecardAddResponse);
            try
            {
                oRet = oApi.TimeAddPendingTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeApplyTimeCaptureModel
            returning E3EAPIDataObjectModelModelsDataObjectModelApplyResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelApplyResponse TimeApplyTimeCaptureModel(TimeApplyTimeCaptureModelRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelApplyResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelApplyResponse);
            try
            {
                oRet = oApi.TimeApplyTimeCaptureModel( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecaptureModelApplyRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeApplyTimeCaptureModelAsync
            returning E3EAPIDataObjectModelModelsDataObjectModelApplyResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelApplyResponse TimeApplyTimeCaptureModelAsync(TimeApplyTimeCaptureModelAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelApplyResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelApplyResponse);
            try
            {
                oRet = oApi.TimeApplyTimeCaptureModelAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecaptureModelApplyRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCleanupPendingTimecards
            returning E3EAPITimeModelsTimecardCleanupResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCleanupResponse TimeCleanupPendingTimecards(TimeCleanupPendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCleanupResponse oRet = default(E3EAPITimeModelsTimecardCleanupResponse);
            try
            {
                oRet = oApi.TimeCleanupPendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCleanupRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCleanupPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardCleanupResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCleanupResponse TimeCleanupPendingTimecardsAsync(TimeCleanupPendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCleanupResponse oRet = default(E3EAPITimeModelsTimecardCleanupResponse);
            try
            {
                oRet = oApi.TimeCleanupPendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCleanupRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClearTimecapturePostExceptions
            returning E3EAPITimeModelsTimecardClearResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardClearResponse TimeClearTimecapturePostExceptions(TimeClearTimecapturePostExceptionsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardClearResponse oRet = default(E3EAPITimeModelsTimecardClearResponse);
            try
            {
                oRet = oApi.TimeClearTimecapturePostExceptions( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardClearRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClearTimecapturePostExceptionsAsync
            returning E3EAPITimeModelsTimecardClearResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardClearResponse TimeClearTimecapturePostExceptionsAsync(TimeClearTimecapturePostExceptionsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardClearResponse oRet = default(E3EAPITimeModelsTimecardClearResponse);
            try
            {
                oRet = oApi.TimeClearTimecapturePostExceptionsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardClearRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePendingTimecards
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePendingTimecards(TimeClonePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePendingTimecardsAsync
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePendingTimecardsAsync(TimeClonePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePostedTimecards
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecards(TimeClonePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePostedTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePostedTimecardsAsync
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecardsAsync(TimeClonePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePostedTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePostedTimecardsAsPendingTimecards
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecardsAsPendingTimecards(TimeClonePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePostedTimecardsAsPendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeClonePostedTimecardsAsPendingTimecardsAsync
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecardsAsPendingTimecardsAsync(TimeClonePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeClonePostedTimecardsAsPendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCloneTimecaptureCard
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeCloneTimecaptureCard(TimeClonePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeCloneTimecaptureCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCloneTimecaptureCardAsync
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeCloneTimecaptureCardAsync(TimeClonePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeCloneTimecaptureCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreatePendingTimecard
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreatePendingTimecard(TimeCreatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreatePendingTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreatePendingTimecardAsync
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreatePendingTimecardAsync(TimeCreatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreatePendingTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreatePostedTimecard
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreatePostedTimecard(TimeCreatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreatePostedTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreatePostedTimecardAsync
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreatePostedTimecardAsync(TimeCreatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreatePostedTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimeCaptureCard
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreateTimeCaptureCard(TimeCreatePendingTimecardRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreateTimeCaptureCard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimeCaptureCardAsync
            returning E3EAPITimeModelsTimecardCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCreateResponse TimeCreateTimeCaptureCardAsync(TimeCreatePendingTimecardAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCreateResponse oRet = default(E3EAPITimeModelsTimecardCreateResponse);
            try
            {
                oRet = oApi.TimeCreateTimeCaptureCardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimeCaptureModel
            returning E3EAPIDataObjectModelModelsDataObjectModelCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelCreateResponse TimeCreateTimeCaptureModel(TimeCreateTimeCaptureModelRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelCreateResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelCreateResponse);
            try
            {
                oRet = oApi.TimeCreateTimeCaptureModel( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimeCaptureModelAsync
            returning E3EAPIDataObjectModelModelsDataObjectModelCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelCreateResponse TimeCreateTimeCaptureModelAsync(TimeCreateTimeCaptureModelAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelCreateResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelCreateResponse);
            try
            {
                oRet = oApi.TimeCreateTimeCaptureModelAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimecaptureCardFromPosted
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeCreateTimecaptureCardFromPosted(TimeClonePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeCreateTimecaptureCardFromPosted( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeCreateTimecaptureCardFromPostedAsync
            returning E3EAPITimeModelsTimecardCloneResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardCloneResponse TimeCreateTimecaptureCardFromPostedAsync(TimeClonePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardCloneResponse oRet = default(E3EAPITimeModelsTimecardCloneResponse);
            try
            {
                oRet = oApi.TimeCreateTimecaptureCardFromPostedAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardCloneRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeDeletePendingTimecards
            returning E3EAPITimeModelsTimecardDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardDeleteResponse TimeDeletePendingTimecards(TimeDeletePendingTimecardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardDeleteResponse oRet = default(E3EAPITimeModelsTimecardDeleteResponse);
            try
            {
                oRet = oApi.TimeDeletePendingTimecards( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardDeleteRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeDeletePendingTimecardsAsync
            returning E3EAPITimeModelsTimecardDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardDeleteResponse TimeDeletePendingTimecardsAsync(TimeDeletePendingTimecardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardDeleteResponse oRet = default(E3EAPITimeModelsTimecardDeleteResponse);
            try
            {
                oRet = oApi.TimeDeletePendingTimecardsAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITimeModelsTimecardDeleteRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeDeleteTimeCaptureModel
            returning E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse TimeDeleteTimeCaptureModel(TimeDeleteTimeCaptureModelRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse);
            try
            {
                oRet = oApi.TimeDeleteTimeCaptureModel( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeDeleteTimeCaptureModelAsync
            returning E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse TimeDeleteTimeCaptureModelAsync(TimeDeleteTimeCaptureModelAsyncRequest oClassRequestValue)
        {
            E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse oRet = default(E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse);
            try
            {
                oRet = oApi.TimeDeleteTimeCaptureModelAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetActiveTimers
            returning E3EAPITimeModelsActiveTimersResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsActiveTimersResponse TimeGetActiveTimers(TimeGetTimeCaptureAllCardsRequest oClassRequestValue)
        {
            E3EAPITimeModelsActiveTimersResponse oRet = default(E3EAPITimeModelsActiveTimersResponse);
            try
            {
                oRet = oApi.TimeGetActiveTimers( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetActiveTimersAsync
            returning E3EAPITimeModelsActiveTimersResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsActiveTimersResponse TimeGetActiveTimersAsync(TimeGetTimeCaptureAllCardsAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsActiveTimersResponse oRet = default(E3EAPITimeModelsActiveTimersResponse);
            try
            {
                oRet = oApi.TimeGetActiveTimersAsync( oClassRequestValue.index, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.itemIds, oClassRequestValue.attributesToInclude, oClassRequestValue.filterXOQL, oClassRequestValue.filterPredicates, oClassRequestValue.filterOperator, oClassRequestValue.filterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetCalendarReport
            returning E3EAPITimeModelsCalendarReportGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsCalendarReportGetResponse TimeGetCalendarReport(TimeGetCalendarReportRequest oClassRequestValue)
        {
            E3EAPITimeModelsCalendarReportGetResponse oRet = default(E3EAPITimeModelsCalendarReportGetResponse);
            try
            {
                oRet = oApi.TimeGetCalendarReport( oClassRequestValue.timekeeper, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.matter, oClassRequestValue.client, oClassRequestValue.includeHours, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetCalendarReportAsync
            returning E3EAPITimeModelsCalendarReportGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsCalendarReportGetResponse TimeGetCalendarReportAsync(TimeGetCalendarReportAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsCalendarReportGetResponse oRet = default(E3EAPITimeModelsCalendarReportGetResponse);
            try
            {
                oRet = oApi.TimeGetCalendarReportAsync( oClassRequestValue.timekeeper, oClassRequestValue.startDate, oClassRequestValue.endDate, oClassRequestValue.matter, oClassRequestValue.client, oClassRequestValue.includeHours, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewPendingTimecard
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPendingTimecard(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewPendingTimecard( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method TimeGetNewPendingTimecardAsync
            returning E3EAPITimeModelsTimecardTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPendingTimecardAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPITimeModelsTimecardTemplateResponse oRet = default(E3EAPITimeModelsTimecardTemplateResponse);
            try
            {
                oRet = oApi.TimeGetNewPendingTimecardAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
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