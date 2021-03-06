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
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.AzureStack.Management
{
    /// <summary>
    /// Your documentation here.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    internal partial class ResourceProviderOperations : IServiceOperations<AzureStackClient>, IResourceProviderOperations
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ResourceProviderOperations(AzureStackClient client)
        {
            this._client = client;
        }
        
        private AzureStackClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.AzureStack.Management.AzureStackClient.
        /// </summary>
        public AzureStackClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceProviderNamespace'>
        /// Required. Your documentation here.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public async Task<ResourceProviderGetResult> GetAsync(string resourceProviderNamespace, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException("resourceProviderNamespace");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceProviderNamespace", resourceProviderNamespace);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(resourceProviderNamespace);
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(this.Client.ApiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
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
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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
                    ResourceProviderGetResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ResourceProviderGetResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            ResourceProviderDefinition resourceProviderInstance = new ResourceProviderDefinition();
                            result.ResourceProvider = resourceProviderInstance;
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                resourceProviderInstance.Id = idInstance;
                            }
                            
                            JToken namespaceValue = responseDoc["namespace"];
                            if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                            {
                                string namespaceInstance = ((string)namespaceValue);
                                resourceProviderInstance.Namespace = namespaceInstance;
                            }
                            
                            JToken resourceTypesArray = responseDoc["resourceTypes"];
                            if (resourceTypesArray != null && resourceTypesArray.Type != JTokenType.Null)
                            {
                                foreach (JToken resourceTypesValue in ((JArray)resourceTypesArray))
                                {
                                    ProviderResourceType providerResourceTypeInstance = new ProviderResourceType();
                                    resourceProviderInstance.ResourceTypes.Add(providerResourceTypeInstance);
                                    
                                    JToken resourceTypeValue = resourceTypesValue["resourceType"];
                                    if (resourceTypeValue != null && resourceTypeValue.Type != JTokenType.Null)
                                    {
                                        string resourceTypeInstance = ((string)resourceTypeValue);
                                        providerResourceTypeInstance.ResourceType = resourceTypeInstance;
                                    }
                                    
                                    JToken locationsArray = resourceTypesValue["locations"];
                                    if (locationsArray != null && locationsArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken locationsValue in ((JArray)locationsArray))
                                        {
                                            providerResourceTypeInstance.Locations.Add(((string)locationsValue));
                                        }
                                    }
                                    
                                    JToken apiVersionsArray = resourceTypesValue["apiVersions"];
                                    if (apiVersionsArray != null && apiVersionsArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken apiVersionsValue in ((JArray)apiVersionsArray))
                                        {
                                            providerResourceTypeInstance.ApiVersions.Add(((string)apiVersionsValue));
                                        }
                                    }
                                    
                                    JToken propertiesValue = resourceTypesValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        string propertiesInstance = propertiesValue.ToString(Newtonsoft.Json.Formatting.Indented);
                                        providerResourceTypeInstance.Properties = propertiesInstance;
                                    }
                                }
                            }
                            
                            JToken registrationStateValue = responseDoc["registrationState"];
                            if (registrationStateValue != null && registrationStateValue.Type != JTokenType.Null)
                            {
                                SubscriptionRegistrationState registrationStateInstance = ((SubscriptionRegistrationState)Enum.Parse(typeof(SubscriptionRegistrationState), ((string)registrationStateValue), true));
                                resourceProviderInstance.RegistrationState = registrationStateInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public async Task<ResourceProviderListResult> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=" + Uri.EscapeDataString(this.Client.ApiVersion));
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
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
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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
                    ResourceProviderListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ResourceProviderListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    ResourceProviderDefinition resourceProviderDefinitionInstance = new ResourceProviderDefinition();
                                    result.ResourceProviders.Add(resourceProviderDefinitionInstance);
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        resourceProviderDefinitionInstance.Id = idInstance;
                                    }
                                    
                                    JToken namespaceValue = valueValue["namespace"];
                                    if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                                    {
                                        string namespaceInstance = ((string)namespaceValue);
                                        resourceProviderDefinitionInstance.Namespace = namespaceInstance;
                                    }
                                    
                                    JToken resourceTypesArray = valueValue["resourceTypes"];
                                    if (resourceTypesArray != null && resourceTypesArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken resourceTypesValue in ((JArray)resourceTypesArray))
                                        {
                                            ProviderResourceType providerResourceTypeInstance = new ProviderResourceType();
                                            resourceProviderDefinitionInstance.ResourceTypes.Add(providerResourceTypeInstance);
                                            
                                            JToken resourceTypeValue = resourceTypesValue["resourceType"];
                                            if (resourceTypeValue != null && resourceTypeValue.Type != JTokenType.Null)
                                            {
                                                string resourceTypeInstance = ((string)resourceTypeValue);
                                                providerResourceTypeInstance.ResourceType = resourceTypeInstance;
                                            }
                                            
                                            JToken locationsArray = resourceTypesValue["locations"];
                                            if (locationsArray != null && locationsArray.Type != JTokenType.Null)
                                            {
                                                foreach (JToken locationsValue in ((JArray)locationsArray))
                                                {
                                                    providerResourceTypeInstance.Locations.Add(((string)locationsValue));
                                                }
                                            }
                                            
                                            JToken apiVersionsArray = resourceTypesValue["apiVersions"];
                                            if (apiVersionsArray != null && apiVersionsArray.Type != JTokenType.Null)
                                            {
                                                foreach (JToken apiVersionsValue in ((JArray)apiVersionsArray))
                                                {
                                                    providerResourceTypeInstance.ApiVersions.Add(((string)apiVersionsValue));
                                                }
                                            }
                                            
                                            JToken propertiesValue = resourceTypesValue["properties"];
                                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                            {
                                                string propertiesInstance = propertiesValue.ToString(Newtonsoft.Json.Formatting.Indented);
                                                providerResourceTypeInstance.Properties = propertiesInstance;
                                            }
                                        }
                                    }
                                    
                                    JToken registrationStateValue = valueValue["registrationState"];
                                    if (registrationStateValue != null && registrationStateValue.Type != JTokenType.Null)
                                    {
                                        SubscriptionRegistrationState registrationStateInstance = ((SubscriptionRegistrationState)Enum.Parse(typeof(SubscriptionRegistrationState), ((string)registrationStateValue), true));
                                        resourceProviderDefinitionInstance.RegistrationState = registrationStateInstance;
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["@odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = ((string)odatanextLinkValue);
                                result.NextLink = odatanextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='nextLink'>
        /// Required. Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public async Task<ResourceProviderListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken)
        {
            // Validate
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextLink", nextLink);
                TracingAdapter.Enter(invocationId, this, "ListNextAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + Uri.EscapeDataString(nextLink);
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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
                    ResourceProviderListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ResourceProviderListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    ResourceProviderDefinition resourceProviderDefinitionInstance = new ResourceProviderDefinition();
                                    result.ResourceProviders.Add(resourceProviderDefinitionInstance);
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        resourceProviderDefinitionInstance.Id = idInstance;
                                    }
                                    
                                    JToken namespaceValue = valueValue["namespace"];
                                    if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                                    {
                                        string namespaceInstance = ((string)namespaceValue);
                                        resourceProviderDefinitionInstance.Namespace = namespaceInstance;
                                    }
                                    
                                    JToken resourceTypesArray = valueValue["resourceTypes"];
                                    if (resourceTypesArray != null && resourceTypesArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken resourceTypesValue in ((JArray)resourceTypesArray))
                                        {
                                            ProviderResourceType providerResourceTypeInstance = new ProviderResourceType();
                                            resourceProviderDefinitionInstance.ResourceTypes.Add(providerResourceTypeInstance);
                                            
                                            JToken resourceTypeValue = resourceTypesValue["resourceType"];
                                            if (resourceTypeValue != null && resourceTypeValue.Type != JTokenType.Null)
                                            {
                                                string resourceTypeInstance = ((string)resourceTypeValue);
                                                providerResourceTypeInstance.ResourceType = resourceTypeInstance;
                                            }
                                            
                                            JToken locationsArray = resourceTypesValue["locations"];
                                            if (locationsArray != null && locationsArray.Type != JTokenType.Null)
                                            {
                                                foreach (JToken locationsValue in ((JArray)locationsArray))
                                                {
                                                    providerResourceTypeInstance.Locations.Add(((string)locationsValue));
                                                }
                                            }
                                            
                                            JToken apiVersionsArray = resourceTypesValue["apiVersions"];
                                            if (apiVersionsArray != null && apiVersionsArray.Type != JTokenType.Null)
                                            {
                                                foreach (JToken apiVersionsValue in ((JArray)apiVersionsArray))
                                                {
                                                    providerResourceTypeInstance.ApiVersions.Add(((string)apiVersionsValue));
                                                }
                                            }
                                            
                                            JToken propertiesValue = resourceTypesValue["properties"];
                                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                            {
                                                string propertiesInstance = propertiesValue.ToString(Newtonsoft.Json.Formatting.Indented);
                                                providerResourceTypeInstance.Properties = propertiesInstance;
                                            }
                                        }
                                    }
                                    
                                    JToken registrationStateValue = valueValue["registrationState"];
                                    if (registrationStateValue != null && registrationStateValue.Type != JTokenType.Null)
                                    {
                                        SubscriptionRegistrationState registrationStateInstance = ((SubscriptionRegistrationState)Enum.Parse(typeof(SubscriptionRegistrationState), ((string)registrationStateValue), true));
                                        resourceProviderDefinitionInstance.RegistrationState = registrationStateInstance;
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["@odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = ((string)odatanextLinkValue);
                                result.NextLink = odatanextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
