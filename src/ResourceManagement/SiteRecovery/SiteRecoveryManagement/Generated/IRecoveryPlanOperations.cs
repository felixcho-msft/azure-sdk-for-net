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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of recovery plan operations for the Site Recovery extension.
    /// </summary>
    public partial interface IRecoveryPlanOperations
    {
        /// <summary>
        /// Commit failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginCommitFailoverAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Create recovery plan input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginCreatingAsync(string recoveryPlanName, CreateRecoveryPlanInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeletingAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Planned failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan planned failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginPlannedFailoverAsync(string recoveryPlanName, RecoveryPlanPlannedFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Reprotects the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginReprotectAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Test failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan test failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginTestFailoverAsync(string recoveryPlanName, RecoveryPlanTestFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unplanned failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan unplanned failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginUnplannedFailoverAsync(string recoveryPlanName, RecoveryPlanUnplannedFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the given recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Update recovery plan input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginUpdatingAsync(string recoveryPlanName, UpdateRecoveryPlanInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Commit failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> CommitFailoverAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Create recovery plan input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> CreateAsync(string recoveryPlanName, CreateRecoveryPlanInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a recovery plan
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the recovery plan by Id.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the recovery plan object.
        /// </returns>
        Task<RecoveryPlanResponse> GetAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<RecoveryPlanOperationResponse> GetCommitFailoverStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<CreateRecoveryPlanOperationResponse> GetCreateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<DeleteRecoveryPlanOperationResponse> GetDeleteStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<RecoveryPlanOperationResponse> GetPlannedFailoverStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<RecoveryPlanOperationResponse> GetReprotectStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<RecoveryPlanOperationResponse> GetTestFailoverStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<RecoveryPlanOperationResponse> GetUnplannedFailoverStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<UpdateRecoveryPlanOperationResponse> GetUpdateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the list of all recovery plans under the vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list recovery plan operation.
        /// </returns>
        Task<RecoveryPlanListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Planned failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan planned failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> PlannedFailoverAsync(string recoveryPlanName, RecoveryPlanPlannedFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Reprotects the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> ReprotectAsync(string recoveryPlanName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Test failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan test failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> TestFailoverAsync(string recoveryPlanName, RecoveryPlanTestFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Unplanned failover of the recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery plan unplanned failover input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> UnplannedFailoverAsync(string recoveryPlanName, RecoveryPlanUnplannedFailoverInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the given recovery plan.
        /// </summary>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Update recovery plan input.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> UpdateAsync(string recoveryPlanName, UpdateRecoveryPlanInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
