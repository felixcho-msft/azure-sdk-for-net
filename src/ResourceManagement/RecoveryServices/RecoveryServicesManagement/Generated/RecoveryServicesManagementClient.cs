// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices
{
    public partial class RecoveryServicesManagementClient : ServiceClient<RecoveryServicesManagementClient>, IRecoveryServicesManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _resourceNamespace;
        
        public string ResourceNamespace
        {
            get { return this._resourceNamespace; }
            set { this._resourceNamespace = value; }
        }
        
        private IReplicationUsagesOperations _replicationUsages;
        
        /// <summary>
        /// Definition of vault usage operations for the Recovery Services
        /// extension.
        /// </summary>
        public virtual IReplicationUsagesOperations ReplicationUsages
        {
            get { return this._replicationUsages; }
        }
        
        private IResourceGroupsOperations _resourceGroup;
        
        /// <summary>
        /// Definition of cloud service operations for the Recovery services
        /// extension.
        /// </summary>
        public virtual IResourceGroupsOperations ResourceGroup
        {
            get { return this._resourceGroup; }
        }
        
        private IVaultExtendedInfoOperations _vaultExtendedInfo;
        
        /// <summary>
        /// Definition of vault extended info operations for the Recovery
        /// Services extension.
        /// </summary>
        public virtual IVaultExtendedInfoOperations VaultExtendedInfo
        {
            get { return this._vaultExtendedInfo; }
        }
        
        private IVaultOperations _vaults;
        
        /// <summary>
        /// Definition of vault operations for the Recovery Services extension.
        /// </summary>
        public virtual IVaultOperations Vaults
        {
            get { return this._vaults; }
        }
        
        private IVaultUsageOperations _vaultUsage;
        
        /// <summary>
        /// Definition of vault operations for the Recovery Services extension.
        /// </summary>
        public virtual IVaultUsageOperations VaultUsage
        {
            get { return this._vaultUsage; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        public RecoveryServicesManagementClient()
            : base()
        {
            this._replicationUsages = new ReplicationUsagesOperations(this);
            this._resourceGroup = new ResourceGroupsOperations(this);
            this._vaultExtendedInfo = new VaultExtendedInfoOperations(this);
            this._vaults = new VaultOperations(this);
            this._vaultUsage = new VaultUsageOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public RecoveryServicesManagementClient(string resourceNamespace, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceNamespace = resourceNamespace;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public RecoveryServicesManagementClient(string resourceNamespace, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceNamespace = resourceNamespace;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._replicationUsages = new ReplicationUsagesOperations(this);
            this._resourceGroup = new ResourceGroupsOperations(this);
            this._vaultExtendedInfo = new VaultExtendedInfoOperations(this);
            this._vaults = new VaultOperations(this);
            this._vaultUsage = new VaultUsageOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesManagementClient(string resourceNamespace, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceNamespace = resourceNamespace;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoveryServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesManagementClient(string resourceNamespace, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceNamespace = resourceNamespace;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// RecoveryServicesManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of RecoveryServicesManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<RecoveryServicesManagementClient> client)
        {
            base.Clone(client);
            
            if (client is RecoveryServicesManagementClient)
            {
                RecoveryServicesManagementClient clonedClient = ((RecoveryServicesManagementClient)client);
                
                clonedClient._resourceNamespace = this._resourceNamespace;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// Required. The request ID for the request you wish to track. The
        /// request ID is returned in the x-ms-request-id response header for
        /// every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<RecoveryServicesOperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken)
        {
            // Validate
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("requestId", requestId);
                TracingAdapter.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Credentials.SubscriptionId);
            }
            url = url + "/operations/";
            url = url + Uri.EscapeDataString(requestId);
            string baseUrl = this.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RecoveryServicesOperationStatusResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new RecoveryServicesOperationStatusResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        JToken recoveryServicesOperationStatusResponseValue = responseDoc["RecoveryServicesOperationStatusResponse"];
                        if (recoveryServicesOperationStatusResponseValue != null && recoveryServicesOperationStatusResponseValue.Type != JTokenType.Null)
                        {
                            RecoveryServicesOperationStatusResponse recoveryServicesOperationStatusResponseInstance = new RecoveryServicesOperationStatusResponse();
                            
                            JToken idValue = recoveryServicesOperationStatusResponseValue["ID"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                recoveryServicesOperationStatusResponseInstance.Id = idInstance;
                            }
                            
                            JToken statusValue = recoveryServicesOperationStatusResponseValue["Status"];
                            if (statusValue != null && statusValue.Type != JTokenType.Null)
                            {
                                RecoveryServicesOperationStatus statusInstance = ((RecoveryServicesOperationStatus)Enum.Parse(typeof(RecoveryServicesOperationStatus), ((string)statusValue), true));
                                recoveryServicesOperationStatusResponseInstance.Status = statusInstance;
                            }
                            
                            JToken httpStatusCodeValue = recoveryServicesOperationStatusResponseValue["HttpStatusCode"];
                            if (httpStatusCodeValue != null && httpStatusCodeValue.Type != JTokenType.Null)
                            {
                                HttpStatusCode httpStatusCodeInstance = ((HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), ((string)httpStatusCodeValue), true));
                                recoveryServicesOperationStatusResponseInstance.HttpStatusCode = httpStatusCodeInstance;
                            }
                            
                            JToken errorValue = recoveryServicesOperationStatusResponseValue["Error"];
                            if (errorValue != null && errorValue.Type != JTokenType.Null)
                            {
                                RecoveryServicesOperationStatusResponse.ErrorDetails errorInstance = new RecoveryServicesOperationStatusResponse.ErrorDetails();
                                recoveryServicesOperationStatusResponseInstance.Error = errorInstance;
                                
                                JToken codeValue = errorValue["Code"];
                                if (codeValue != null && codeValue.Type != JTokenType.Null)
                                {
                                    string codeInstance = ((string)codeValue);
                                    errorInstance.Code = codeInstance;
                                }
                                
                                JToken messageValue = errorValue["Message"];
                                if (messageValue != null && messageValue.Type != JTokenType.Null)
                                {
                                    string messageInstance = ((string)messageValue);
                                    errorInstance.Message = messageInstance;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
