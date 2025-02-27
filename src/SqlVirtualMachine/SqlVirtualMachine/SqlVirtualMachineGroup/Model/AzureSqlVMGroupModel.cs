// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.SqlVirtualMachine.Models;
using Microsoft.WindowsAzure.Commands.Common.Attributes;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.SqlVirtualMachine.SqlVirtualMachine.Model
{
    /// <summary>
    /// Represents the core properties of an Azure Sql Virtual Machine Group. It mirrors the .NET client object 
    /// Microsoft.Azure.Management.SqlVirtualMachine.Models.SqlVirtualMachineGroup
    /// </summary>
    public class AzureSqlVMGroupModel
    {
        public AzureSqlVMGroupModel(string resourceGroupName)
        {
            this.ResourceGroupName = resourceGroupName;
        }

        /// <summary>
        /// Gets or sets the name of the resource group the sql virtual machine group is in
        /// </summary>
        [Ps1Xml(Label = "ResourceGroupName", Target = ViewControl.Table, Position = 1)]
        public string ResourceGroupName { get; }

        /// <summary>
        /// Gets or sets the name of the sql virtual machine group
        /// </summary>
        [Ps1Xml(Label = "Name", Target = ViewControl.Table, Position = 0)]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the location the sql virtual machine is in
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the sql virtual machine group offer
        /// </summary>
        [Ps1Xml(Label = "Offer", Target = ViewControl.Table, Position = 3)]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the sql virtual machine group sku
        /// </summary>
        [Ps1Xml(Label = "Sku", Target = ViewControl.Table, Position = 2)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the sql virtual machine.
        /// </summary>
        public Dictionary<string, string> Tag { get; set; }

        /// <summary>
        /// Gets or sets the resource id of the sql virtual machine
        /// </summary>
        public string ResourceId { get; set; }

        public WsfcDomainProfile WsfcDomainProfile { get; set; }
    }
}
