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
using System.Linq;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Response for Azure Sql Import/Export Status operation.
    /// </summary>
    public partial class ImportExportOperationStatusResponseProperties : ImportExportResponse
    {
        private string _blobUri;
        
        /// <summary>
        /// Optional. Gets or sets the blob uri.
        /// </summary>
        public string BlobUri
        {
            get { return this._blobUri; }
            set { this._blobUri = value; }
        }
        
        private string _databaseName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the Azure SQL Database.
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets or sets the error message returned from the server.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the operation status last modified time.
        /// </summary>
        public string LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private string _queuedTime;
        
        /// <summary>
        /// Optional. Gets or sets the operation queued time.
        /// </summary>
        public string QueuedTime
        {
            get { return this._queuedTime; }
            set { this._queuedTime = value; }
        }
        
        private string _requestType;
        
        /// <summary>
        /// Optional. Gets or sets the request type of the operation.
        /// </summary>
        public string RequestType
        {
            get { return this._requestType; }
            set { this._requestType = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the Azure SQL Server.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        private string _statusMessage;
        
        /// <summary>
        /// Optional. Gets or sets the status message returned from the server.
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ImportExportOperationStatusResponseProperties class.
        /// </summary>
        public ImportExportOperationStatusResponseProperties()
        {
        }
    }
}
