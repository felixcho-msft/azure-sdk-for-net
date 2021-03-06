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
using Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models;

namespace Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models
{
    /// <summary>
    /// A Data Lake Analytics catalog U-SQL distribution information object.
    /// </summary>
    public partial class USqlDistributionInfo
    {
        private int? _count;
        
        /// <summary>
        /// Optional. Gets or sets the count of indices using this distribution.
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private IList<USqlDirectedColumn> _keys;
        
        /// <summary>
        /// Optional. Gets or sets the list of directed columns in the
        /// distribution
        /// </summary>
        public IList<USqlDirectedColumn> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }
        
        private int? _type;
        
        /// <summary>
        /// Optional. Gets or sets the type of this distribution.
        /// </summary>
        public int? Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the USqlDistributionInfo class.
        /// </summary>
        public USqlDistributionInfo()
        {
            this.Keys = new LazyList<USqlDirectedColumn>();
        }
    }
}
