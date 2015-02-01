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
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public partial class StreamAnalyticsManagementClient : ServiceClient<StreamAnalyticsManagementClient>, IStreamAnalyticsManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IInputOperations _inputs;
        
        /// <summary>
        /// Operations for managing the input of the stream analytics job.
        /// </summary>
        public virtual IInputOperations Inputs
        {
            get { return this._inputs; }
        }
        
        private IJobOperations _streamingJobs;
        
        /// <summary>
        /// Operations for managing the stream analytics job.
        /// </summary>
        public virtual IJobOperations StreamingJobs
        {
            get { return this._streamingJobs; }
        }
        
        private IOutputOperations _outputs;
        
        /// <summary>
        /// Operations for managing the output of the stream analytics job.
        /// </summary>
        public virtual IOutputOperations Outputs
        {
            get { return this._outputs; }
        }
        
        private ISubscriptionOperations _subscriptions;
        
        /// <summary>
        /// Operations for Azure Stream Analytics subscription information.
        /// </summary>
        public virtual ISubscriptionOperations Subscriptions
        {
            get { return this._subscriptions; }
        }
        
        private ITransformationOperations _transformations;
        
        /// <summary>
        /// Operations for managing the transformation definition of the stream
        /// analytics job.
        /// </summary>
        public virtual ITransformationOperations Transformations
        {
            get { return this._transformations; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        public StreamAnalyticsManagementClient()
            : base()
        {
            this._inputs = new InputOperations(this);
            this._streamingJobs = new JobOperations(this);
            this._outputs = new OutputOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._transformations = new TransformationOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(60);
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. The URI used as the base for all Service Management
        /// requests.
        /// </param>
        public StreamAnalyticsManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        public StreamAnalyticsManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StreamAnalyticsManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._inputs = new InputOperations(this);
            this._streamingJobs = new JobOperations(this);
            this._outputs = new OutputOperations(this);
            this._subscriptions = new SubscriptionOperations(this);
            this._transformations = new TransformationOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(60);
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. The URI used as the base for all Service Management
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StreamAnalyticsManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the StreamAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public StreamAnalyticsManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// StreamAnalyticsManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of StreamAnalyticsManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<StreamAnalyticsManagementClient> client)
        {
            base.Clone(client);
            
            if (client is StreamAnalyticsManagementClient)
            {
                StreamAnalyticsManagementClient clonedClient = ((StreamAnalyticsManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public async Task<LongRunningOperationResponse> GetLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken)
        {
            // Validate
            if (operationStatusLink == null)
            {
                throw new ArgumentNullException("operationStatusLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationStatusLink", operationStatusLink);
                TracingAdapter.Enter(invocationId, this, "GetLongRunningOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + operationStatusLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2014-12-01-preview");
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted && statusCode != HttpStatusCode.NoContent && statusCode != HttpStatusCode.NotFound && statusCode != HttpStatusCode.Conflict && statusCode != HttpStatusCode.PreconditionFailed)
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
                    LongRunningOperationResponse result = null;
                    // Deserialize Response
                    result = new LongRunningOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (statusCode == HttpStatusCode.PreconditionFailed)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.Conflict)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.NoContent)
                    {
                        result.Status = OperationStatus.Succeeded;
                    }
                    if (statusCode == HttpStatusCode.OK)
                    {
                        result.Status = OperationStatus.Succeeded;
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
        
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public async Task<DataSourceTestConnectionResponse> GetTestConnectionStatusAsync(string operationStatusLink, CancellationToken cancellationToken)
        {
            // Validate
            if (operationStatusLink == null)
            {
                throw new ArgumentNullException("operationStatusLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationStatusLink", operationStatusLink);
                TracingAdapter.Enter(invocationId, this, "GetTestConnectionStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + operationStatusLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-client-request-id", Guid.NewGuid().ToString());
                httpRequest.Headers.Add("x-ms-version", "2014-12-01-preview");
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted && statusCode != HttpStatusCode.NoContent && statusCode != HttpStatusCode.BadRequest)
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
                    DataSourceTestConnectionResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted || statusCode == HttpStatusCode.NoContent || statusCode == HttpStatusCode.BadRequest)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DataSourceTestConnectionResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken statusValue = responseDoc["status"];
                            if (statusValue != null && statusValue.Type != JTokenType.Null)
                            {
                                string statusInstance = ((string)statusValue);
                                result.DataSourceTestStatus = statusInstance;
                            }
                            
                            JToken errorValue = responseDoc["error"];
                            if (errorValue != null && errorValue.Type != JTokenType.Null)
                            {
                                ErrorResponse errorInstance = new ErrorResponse();
                                result.Error = errorInstance;
                                
                                JToken codeValue = errorValue["code"];
                                if (codeValue != null && codeValue.Type != JTokenType.Null)
                                {
                                    string codeInstance = ((string)codeValue);
                                    errorInstance.Code = codeInstance;
                                }
                                
                                JToken messageValue = errorValue["message"];
                                if (messageValue != null && messageValue.Type != JTokenType.Null)
                                {
                                    string messageInstance = ((string)messageValue);
                                    errorInstance.Message = messageInstance;
                                }
                                
                                JToken detailsValue = errorValue["details"];
                                if (detailsValue != null && detailsValue.Type != JTokenType.Null)
                                {
                                    ErrorDetailsResponse detailsInstance = new ErrorDetailsResponse();
                                    errorInstance.Details = detailsInstance;
                                    
                                    JToken codeValue2 = detailsValue["code"];
                                    if (codeValue2 != null && codeValue2.Type != JTokenType.Null)
                                    {
                                        string codeInstance2 = ((string)codeValue2);
                                        detailsInstance.Code = codeInstance2;
                                    }
                                    
                                    JToken messageValue2 = detailsValue["message"];
                                    if (messageValue2 != null && messageValue2.Type != JTokenType.Null)
                                    {
                                        string messageInstance2 = ((string)messageValue2);
                                        detailsInstance.Message = messageInstance2;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.BadRequest)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (result.DataSourceTestStatus == DataSourceTestStatus.TestFailed)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (result.DataSourceTestStatus == DataSourceTestStatus.TestSucceeded)
                    {
                        result.Status = OperationStatus.Succeeded;
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
