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
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public static partial class GroupUsersOperationsExtensions
    {
        /// <summary>
        /// Include existing user to existing group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='uid'>
        /// Required. Identifier of the user.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Add(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, string uid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IGroupUsersOperations)s).AddAsync(resourceGroupName, serviceName, gid, uid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Include existing user to existing group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='uid'>
        /// Required. Identifier of the user.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> AddAsync(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, string uid)
        {
            return operations.AddAsync(resourceGroupName, serviceName, gid, uid, CancellationToken.None);
        }
        
        /// <summary>
        /// List all group users.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        public static UserListResponse List(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, QueryParameters query)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IGroupUsersOperations)s).ListAsync(resourceGroupName, serviceName, gid, query);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all group users.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        public static Task<UserListResponse> ListAsync(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, QueryParameters query)
        {
            return operations.ListAsync(resourceGroupName, serviceName, gid, query, CancellationToken.None);
        }
        
        /// <summary>
        /// List all group users.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        public static UserListResponse ListNext(this IGroupUsersOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IGroupUsersOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all group users.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        public static Task<UserListResponse> ListNextAsync(this IGroupUsersOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Remove existing user from existing group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='uid'>
        /// Required. Identifier of the user.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Remove(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, string uid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IGroupUsersOperations)s).RemoveAsync(resourceGroupName, serviceName, gid, uid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Remove existing user from existing group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.IGroupUsersOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='gid'>
        /// Required. Identifier of the group.
        /// </param>
        /// <param name='uid'>
        /// Required. Identifier of the user.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RemoveAsync(this IGroupUsersOperations operations, string resourceGroupName, string serviceName, string gid, string uid)
        {
            return operations.RemoveAsync(resourceGroupName, serviceName, gid, uid, CancellationToken.None);
        }
    }
}
