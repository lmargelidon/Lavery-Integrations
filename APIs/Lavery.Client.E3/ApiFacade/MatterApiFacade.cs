
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
    public class MatterApiFacade : Object
    {
        MatterApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public MatterApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new MatterApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateMatter
            returning E3EAPIMatterModelsMatterCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterCreateResponse MatterCreateMatter(MatterCreateMatterRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterCreateResponse oRet = default(E3EAPIMatterModelsMatterCreateResponse);
            try
            {
                oRet = oApi.MatterCreateMatter( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateMatterAsync
            returning E3EAPIMatterModelsMatterCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterCreateResponse MatterCreateMatterAsync(MatterCreateMatterAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterCreateResponse oRet = default(E3EAPIMatterModelsMatterCreateResponse);
            try
            {
                oRet = oApi.MatterCreateMatterAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateMatterNickname
            returning E3EAPIMatterNicknameModelsMatterNicknameCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameCreateResponse MatterCreateMatterNickname(MatterCreateMatterNicknameRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameCreateResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameCreateResponse);
            try
            {
                oRet = oApi.MatterCreateMatterNickname( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateMatterNicknameAsync
            returning E3EAPIMatterNicknameModelsMatterNicknameCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameCreateResponse MatterCreateMatterNicknameAsync(MatterCreateMatterNicknameAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameCreateResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameCreateResponse);
            try
            {
                oRet = oApi.MatterCreateMatterNicknameAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateTempMatter
            returning E3EAPITempMatterModelsTempMatterCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterCreateResponse MatterCreateTempMatter(MatterCreateTempMatterRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterCreateResponse oRet = default(E3EAPITempMatterModelsTempMatterCreateResponse);
            try
            {
                oRet = oApi.MatterCreateTempMatter( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITempMatterModelsTempMatterCreateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterCreateTempMatterAsync
            returning E3EAPITempMatterModelsTempMatterCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterCreateResponse MatterCreateTempMatterAsync(MatterCreateTempMatterAsyncRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterCreateResponse oRet = default(E3EAPITempMatterModelsTempMatterCreateResponse);
            try
            {
                oRet = oApi.MatterCreateTempMatterAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITempMatterModelsTempMatterCreateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterDeleteMatterNickname
            returning E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse MatterDeleteMatterNickname(MatterDeleteMatterNicknameRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse);
            try
            {
                oRet = oApi.MatterDeleteMatterNickname( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterDeleteMatterNicknameAsync
            returning E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse MatterDeleteMatterNicknameAsync(MatterDeleteMatterNicknameAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse);
            try
            {
                oRet = oApi.MatterDeleteMatterNicknameAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterDeleteTempMatter
            returning E3EAPITempMatterModelsTempMatterDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterDeleteResponse MatterDeleteTempMatter(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterDeleteResponse oRet = default(E3EAPITempMatterModelsTempMatterDeleteResponse);
            try
            {
                oRet = oApi.MatterDeleteTempMatter( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterDeleteTempMatterAsync
            returning E3EAPITempMatterModelsTempMatterDeleteResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterDeleteResponse MatterDeleteTempMatterAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterDeleteResponse oRet = default(E3EAPITempMatterModelsTempMatterDeleteResponse);
            try
            {
                oRet = oApi.MatterDeleteTempMatterAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMatterNicknames
            returning E3EAPIMatterModelsMatterNicknameGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterNicknameGetResponse MatterGetMatterNicknames(MatterGetMatterNicknamesRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterNicknameGetResponse oRet = default(E3EAPIMatterModelsMatterNicknameGetResponse);
            try
            {
                oRet = oApi.MatterGetMatterNicknames( oClassRequestValue.matterNicknameId, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMatterNicknamesAsync
            returning E3EAPIMatterModelsMatterNicknameGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterNicknameGetResponse MatterGetMatterNicknamesAsync(MatterGetMatterNicknamesAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterNicknameGetResponse oRet = default(E3EAPIMatterModelsMatterNicknameGetResponse);
            try
            {
                oRet = oApi.MatterGetMatterNicknamesAsync( oClassRequestValue.matterNicknameId, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMatterSchema
            returning E3EAPIMatterModelsMatterGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetSchemaResponse MatterGetMatterSchema(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetSchemaResponse oRet = default(E3EAPIMatterModelsMatterGetSchemaResponse);
            try
            {
                oRet = oApi.MatterGetMatterSchema( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMatterSchemaAsync
            returning E3EAPIMatterModelsMatterGetSchemaResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetSchemaResponse MatterGetMatterSchemaAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetSchemaResponse oRet = default(E3EAPIMatterModelsMatterGetSchemaResponse);
            try
            {
                oRet = oApi.MatterGetMatterSchemaAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMatters
            returning E3EAPIMatterModelsMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetResponse MatterGetMatters(MatterGetMattersRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetResponse oRet = default(E3EAPIMatterModelsMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetMatters( oClassRequestValue.matterId, oClassRequestValue.mattIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetMattersAsync
            returning E3EAPIMatterModelsMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetResponse MatterGetMattersAsync(MatterGetMattersAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetResponse oRet = default(E3EAPIMatterModelsMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetMattersAsync( oClassRequestValue.matterId, oClassRequestValue.mattIndex, oClassRequestValue.number, oClassRequestValue.advancedFilterChildObjectsToInclude, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetNewMatter
            returning E3EAPIMatterModelsMatterTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterTemplateResponse MatterGetNewMatter(ClientGetClientSchemaRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterTemplateResponse oRet = default(E3EAPIMatterModelsMatterTemplateResponse);
            try
            {
                oRet = oApi.MatterGetNewMatter( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetNewMatterAsync
            returning E3EAPIMatterModelsMatterTemplateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterTemplateResponse MatterGetNewMatterAsync(ClientGetClientSchemaAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterTemplateResponse oRet = default(E3EAPIMatterModelsMatterTemplateResponse);
            try
            {
                oRet = oApi.MatterGetNewMatterAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetTempMatterNameList
            returning E3EAPIMatterModelsTempMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMatterNameList(MatterGetTempMatterNameListRequest oClassRequestValue)
        {
            E3EAPIMatterModelsTempMatterGetResponse oRet = default(E3EAPIMatterModelsTempMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetTempMatterNameList( oClassRequestValue.tempMatterID, oClassRequestValue.tempMatterName, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetTempMatterNameListAsync
            returning E3EAPIMatterModelsTempMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMatterNameListAsync(MatterGetTempMatterNameListAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsTempMatterGetResponse oRet = default(E3EAPIMatterModelsTempMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetTempMatterNameListAsync( oClassRequestValue.tempMatterID, oClassRequestValue.tempMatterName, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetTempMatters
            returning E3EAPIMatterModelsTempMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMatters(MatterGetTempMatterNameListRequest oClassRequestValue)
        {
            E3EAPIMatterModelsTempMatterGetResponse oRet = default(E3EAPIMatterModelsTempMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetTempMatters( oClassRequestValue.tempMatterID, oClassRequestValue.tempMatterName, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterGetTempMattersAsync
            returning E3EAPIMatterModelsTempMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMattersAsync(MatterGetTempMatterNameListAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsTempMatterGetResponse oRet = default(E3EAPIMatterModelsTempMatterGetResponse);
            try
            {
                oRet = oApi.MatterGetTempMattersAsync( oClassRequestValue.tempMatterID, oClassRequestValue.tempMatterName, oClassRequestValue.timekeeperIndex, oClassRequestValue.timekeeperNumber, oClassRequestValue.timekeeperID, oClassRequestValue.advancedFilterAttributesToInclude, oClassRequestValue.advancedFilterFilterXOQL, oClassRequestValue.advancedFilterFilterPredicates, oClassRequestValue.advancedFilterFilterOperator, oClassRequestValue.advancedFilterFilterGroups, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterModelFromMatters
            returning E3EAPIMatterModelsMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetResponse MatterModelFromMatters(ClientModelFromClientsRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetResponse oRet = default(E3EAPIMatterModelsMatterGetResponse);
            try
            {
                oRet = oApi.MatterModelFromMatters( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterModelFromMattersAsync
            returning E3EAPIMatterModelsMatterGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterGetResponse MatterModelFromMattersAsync(ClientModelFromClientsAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterGetResponse oRet = default(E3EAPIMatterModelsMatterGetResponse);
            try
            {
                oRet = oApi.MatterModelFromMattersAsync( oClassRequestValue.itemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterReplaceTempMatter
            returning E3EAPITempMatterModelsTempMatterReplaceResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterReplaceResponse MatterReplaceTempMatter(MatterReplaceTempMatterRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterReplaceResponse oRet = default(E3EAPITempMatterModelsTempMatterReplaceResponse);
            try
            {
                oRet = oApi.MatterReplaceTempMatter( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITempMatterModelsTempMatterReplaceRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterReplaceTempMatterAsync
            returning E3EAPITempMatterModelsTempMatterReplaceResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPITempMatterModelsTempMatterReplaceResponse MatterReplaceTempMatterAsync(MatterReplaceTempMatterAsyncRequest oClassRequestValue)
        {
            E3EAPITempMatterModelsTempMatterReplaceResponse oRet = default(E3EAPITempMatterModelsTempMatterReplaceResponse);
            try
            {
                oRet = oApi.MatterReplaceTempMatterAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPITempMatterModelsTempMatterReplaceRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterUpdateMatter
            returning E3EAPIMatterModelsMatterUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterUpdateResponse MatterUpdateMatter(MatterUpdateMatterRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterUpdateResponse oRet = default(E3EAPIMatterModelsMatterUpdateResponse);
            try
            {
                oRet = oApi.MatterUpdateMatter( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterUpdateMatterAsync
            returning E3EAPIMatterModelsMatterUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterUpdateResponse MatterUpdateMatterAsync(MatterUpdateMatterAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterUpdateResponse oRet = default(E3EAPIMatterModelsMatterUpdateResponse);
            try
            {
                oRet = oApi.MatterUpdateMatterAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterUpdateMatterNickname
            returning E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse MatterUpdateMatterNickname(MatterUpdateMatterNicknameRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse);
            try
            {
                oRet = oApi.MatterUpdateMatterNickname( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterUpdateMatterNicknameAsync
            returning E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse MatterUpdateMatterNicknameAsync(MatterUpdateMatterNicknameAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse oRet = default(E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse);
            try
            {
                oRet = oApi.MatterUpdateMatterNicknameAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterValidateMatters
            returning E3EAPIMatterModelsMatterValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterValidateResponse MatterValidateMatters(MatterValidateMattersRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterValidateResponse oRet = default(E3EAPIMatterModelsMatterValidateResponse);
            try
            {
                oRet = oApi.MatterValidateMatters( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterValidateRequest);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method MatterValidateMattersAsync
            returning E3EAPIMatterModelsMatterValidateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIMatterModelsMatterValidateResponse MatterValidateMattersAsync(MatterValidateMattersAsyncRequest oClassRequestValue)
        {
            E3EAPIMatterModelsMatterValidateResponse oRet = default(E3EAPIMatterModelsMatterValidateResponse);
            try
            {
                oRet = oApi.MatterValidateMattersAsync( oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.e3EAPIMatterModelsMatterValidateRequest, oClassRequestValue.cancellationToken).Result;
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