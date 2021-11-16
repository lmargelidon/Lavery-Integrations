
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
    public class AttachmentApiFacade : Object
    {
        AttachmentApi oApi  {get;set;}
        connectionFactory oConnectionFactory;
        public AttachmentApiFacade(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
            oApi = new AttachmentApi(oConnectionFactory.ConnectionString("ConnectionE3RestApi")); 
            if(oConnectionFactory.getKeyValueString("E3RestApi-Authentification").Equals("NTLM", StringComparison.CurrentCultureIgnoreCase))
                oApi.Configuration.ApiClient.RestClient.Authenticator = new RestSharp.Authenticators.NtlmAuthenticator(System.Net.CredentialCache.DefaultNetworkCredentials);
        }
     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadDMSAttachment
            returning E3EAPIAttachmentModelsAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadDMSAttachment(AttachmentDownloadDMSAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadDMSAttachment( oClassRequestValue.attachmentId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadDMSAttachmentAsync
            returning E3EAPIAttachmentModelsAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadDMSAttachmentAsync(AttachmentDownloadDMSAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadDMSAttachmentAsync( oClassRequestValue.attachmentId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadFileAttachment
            returning E3EAPIAttachmentModelsAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadFileAttachment(AttachmentDownloadDMSAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadFileAttachment( oClassRequestValue.attachmentId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadFileAttachmentAsync
            returning E3EAPIAttachmentModelsAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadFileAttachmentAsync(AttachmentDownloadDMSAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadFileAttachmentAsync( oClassRequestValue.attachmentId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadICAttachment
            returning E3EAPIAttachmentModelsICAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsICAttachmentDownloadRequest AttachmentDownloadICAttachment(AttachmentDownloadICAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsICAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsICAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadICAttachment( oClassRequestValue.syncId, oClassRequestValue.archetype, oClassRequestValue.parentItemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentDownloadICAttachmentAsync
            returning E3EAPIAttachmentModelsICAttachmentDownloadRequest class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsICAttachmentDownloadRequest AttachmentDownloadICAttachmentAsync(AttachmentDownloadICAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsICAttachmentDownloadRequest oRet = default(E3EAPIAttachmentModelsICAttachmentDownloadRequest);
            try
            {
                oRet = oApi.AttachmentDownloadICAttachmentAsync( oClassRequestValue.syncId, oClassRequestValue.archetype, oClassRequestValue.parentItemId, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentGetAttachments
            returning E3EAPIAttachmentModelsAttachmentGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentGetResponse AttachmentGetAttachments(AttachmentGetAttachmentsRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentGetResponse oRet = default(E3EAPIAttachmentModelsAttachmentGetResponse);
            try
            {
                oRet = oApi.AttachmentGetAttachments( oClassRequestValue.parentItemIds, oClassRequestValue.archetype, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentGetAttachmentsAsync
            returning E3EAPIAttachmentModelsAttachmentGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentGetResponse AttachmentGetAttachmentsAsync(AttachmentGetAttachmentsAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentGetResponse oRet = default(E3EAPIAttachmentModelsAttachmentGetResponse);
            try
            {
                oRet = oApi.AttachmentGetAttachmentsAsync( oClassRequestValue.parentItemIds, oClassRequestValue.archetype, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentGetDMSParameters
            returning E3EAPIAttachmentModelsDMSParametersGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsDMSParametersGetResponse AttachmentGetDMSParameters(AttachmentGetDMSParametersRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsDMSParametersGetResponse oRet = default(E3EAPIAttachmentModelsDMSParametersGetResponse);
            try
            {
                oRet = oApi.AttachmentGetDMSParameters( oClassRequestValue.archetype, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentGetDMSParametersAsync
            returning E3EAPIAttachmentModelsDMSParametersGetResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsDMSParametersGetResponse AttachmentGetDMSParametersAsync(AttachmentGetDMSParametersAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsDMSParametersGetResponse oRet = default(E3EAPIAttachmentModelsDMSParametersGetResponse);
            try
            {
                oRet = oApi.AttachmentGetDMSParametersAsync( oClassRequestValue.archetype, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadDMSAttachment
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadDMSAttachment(AttachmentUploadDMSAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadDMSAttachment( oClassRequestValue.library, oClassRequestValue.documentClass, oClassRequestValue.documentType, oClassRequestValue.dMSFolder, oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.syncMapID, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadDMSAttachmentAsync
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadDMSAttachmentAsync(AttachmentUploadDMSAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadDMSAttachmentAsync( oClassRequestValue.library, oClassRequestValue.documentClass, oClassRequestValue.documentType, oClassRequestValue.dMSFolder, oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.syncMapID, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadFileAttachment
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadFileAttachment(AttachmentUploadFileAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadFileAttachment( oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadFileAttachmentAsync
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadFileAttachmentAsync(AttachmentUploadFileAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadFileAttachmentAsync( oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadICAttachment
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadICAttachment(AttachmentUploadICAttachmentRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadICAttachment( oClassRequestValue.process, oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw(ex);
            }
            return oRet;
        }     /*
            ----------------------------------------------------------------
            Reflection generation for the call Api method AttachmentUploadICAttachmentAsync
            returning E3EAPIAttachmentModelsAttachmentCreateResponse class response modele
            ----------------------------------------------------------------
        */
        public E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadICAttachmentAsync(AttachmentUploadICAttachmentAsyncRequest oClassRequestValue)
        {
            E3EAPIAttachmentModelsAttachmentCreateResponse oRet = default(E3EAPIAttachmentModelsAttachmentCreateResponse);
            try
            {
                oRet = oApi.AttachmentUploadICAttachmentAsync( oClassRequestValue.process, oClassRequestValue.parentItemId, oClassRequestValue.archetype, oClassRequestValue.subFolder, oClassRequestValue.description, oClassRequestValue.x3ESessionId, oClassRequestValue.x3EUserId, oClassRequestValue.acceptLanguage, oClassRequestValue.cancellationToken).Result;
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