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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The SQL Database Management API includes operations for getting Service
    /// Objective for a subscription.
    /// </summary>
    public partial interface IServiceObjectiveOperations
    {
        /// <summary>
        /// Returns information about a certain Service Objective on a given Id.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the SQL Server to be queried.
        /// </param>
        /// <param name='serviceObjectiveId'>
        /// The Id of the Service Objective to be obtained.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response containing the service objective for a given server and
        /// service objective Id.
        /// </returns>
        Task<ServiceObjectiveGetResponse> GetAsync(string serverName, string serviceObjectiveId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns information about all Service Objectives on a database
        /// server.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the database server to be queried.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response containing the list of service objective for a given
        /// server.
        /// </returns>
        Task<ServiceObjectiveListResponse> ListAsync(string serverName, CancellationToken cancellationToken);
    }
}