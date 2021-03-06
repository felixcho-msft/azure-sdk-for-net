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
    /// The udpate deployment linux configuration.
    /// </summary>
    public partial class LinuxConfiguration
    {
        private IList<string> _excludedPackageNameMasks;
        
        /// <summary>
        /// Optional. Gets or sets the excluded packages of software update
        /// configuration.
        /// </summary>
        public IList<string> ExcludedPackageNameMasks
        {
            get { return this._excludedPackageNameMasks; }
            set { this._excludedPackageNameMasks = value; }
        }
        
        private string _includedPackageClassifications;
        
        /// <summary>
        /// Optional. Gets or sets the linux update package classifications of
        /// software update configuration.
        /// </summary>
        public string IncludedPackageClassifications
        {
            get { return this._includedPackageClassifications; }
            set { this._includedPackageClassifications = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration()
        {
            this.ExcludedPackageNameMasks = new LazyList<string>();
        }
    }
}
