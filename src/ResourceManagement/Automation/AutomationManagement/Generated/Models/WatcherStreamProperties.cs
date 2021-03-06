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
    /// Definition of the watcher stream.
    /// </summary>
    public partial class WatcherStreamProperties
    {
        private string _streamText;
        
        /// <summary>
        /// Optional. Gets or sets the stream text.
        /// </summary>
        public string StreamText
        {
            get { return this._streamText; }
            set { this._streamText = value; }
        }
        
        private string _streamType;
        
        /// <summary>
        /// Optional. Gets or sets the stream type.
        /// </summary>
        public string StreamType
        {
            get { return this._streamType; }
            set { this._streamType = value; }
        }
        
        private string _summary;
        
        /// <summary>
        /// Optional. Gets or sets the summary.
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }
        
        private DateTimeOffset _time;
        
        /// <summary>
        /// Optional. Gets or sets the creation time of the watcher stream.
        /// </summary>
        public DateTimeOffset Time
        {
            get { return this._time; }
            set { this._time = value; }
        }
        
        private IDictionary<string, object> _value;
        
        /// <summary>
        /// Optional. Gets or sets the values of the watcher stream.
        /// </summary>
        public IDictionary<string, object> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        private string _watcherStreamId;
        
        /// <summary>
        /// Optional. Gets or sets the id of the watcher stream.
        /// </summary>
        public string WatcherStreamId
        {
            get { return this._watcherStreamId; }
            set { this._watcherStreamId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WatcherStreamProperties class.
        /// </summary>
        public WatcherStreamProperties()
        {
            this.Value = new LazyDictionary<string, object>();
        }
    }
}
