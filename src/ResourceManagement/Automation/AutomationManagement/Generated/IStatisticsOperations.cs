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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation statistics.  (see
    /// http://aka.ms/azureautomationsdk/statisticsoperations for more
    /// information)
    /// </summary>
    public partial interface IStatisticsOperations
    {
        /// <summary>
        /// Retrieve the statistics for the account.  (see
        /// http://aka.ms/azureautomationsdk/statisticsoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the list operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list statistics operation.
        /// </returns>
        Task<StatisticsListResponse> ListAsync(string resourceGroupName, string automationAccount, StatisticsListParameters parameters, CancellationToken cancellationToken);
    }
}
