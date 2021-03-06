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
using Hyak.Common;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The properties of the create watcher operation.
    /// </summary>
    public partial class WatcherCreateOrUpdateProperties
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the watcher's description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private long _executionFrequencyInSeconds;
        
        /// <summary>
        /// Optional. Gets or sets the frequency at which the watcher is
        /// invoked.
        /// </summary>
        public long ExecutionFrequencyInSeconds
        {
            get { return this._executionFrequencyInSeconds; }
            set { this._executionFrequencyInSeconds = value; }
        }
        
        private string _scriptName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the script the watcher is
        /// attached to, i.e. the name of an existing runbook.
        /// </summary>
        public string ScriptName
        {
            get { return this._scriptName; }
            set { this._scriptName = value; }
        }
        
        private IDictionary<string, string> _scriptParameters;
        
        /// <summary>
        /// Optional. Gets or sets the parameters of the script.
        /// </summary>
        public IDictionary<string, string> ScriptParameters
        {
            get { return this._scriptParameters; }
            set { this._scriptParameters = value; }
        }
        
        private string _scriptRunOn;
        
        /// <summary>
        /// Optional. Gets or sets the name of the hybrid worker group the
        /// watcher will run on.
        /// </summary>
        public string ScriptRunOn
        {
            get { return this._scriptRunOn; }
            set { this._scriptRunOn = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WatcherCreateOrUpdateProperties
        /// class.
        /// </summary>
        public WatcherCreateOrUpdateProperties()
        {
            this.ScriptParameters = new LazyDictionary<string, string>();
        }
    }
}
