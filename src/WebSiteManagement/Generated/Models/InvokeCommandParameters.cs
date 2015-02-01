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

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// The invoke command parameters.
    /// </summary>
    public partial class InvokeCommandParameters
    {
        private string _command;
        
        /// <summary>
        /// Optional. The command to invoke.
        /// </summary>
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }
        
        private string _directory;
        
        /// <summary>
        /// Optional. The directory to invoke command in.
        /// </summary>
        public string Directory
        {
            get { return this._directory; }
            set { this._directory = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InvokeCommandParameters class.
        /// </summary>
        public InvokeCommandParameters()
        {
        }
    }
}
