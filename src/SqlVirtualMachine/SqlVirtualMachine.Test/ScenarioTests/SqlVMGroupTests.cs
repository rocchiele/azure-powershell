﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.SqlVirtualMachine.Test.ScenarioTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.SqlVirtualMachineGroup.Test.ScenarioTests
{
    public class SqlVMGroupTests : SqlVirtualMachineTestsBase
    {
        public SqlVMGroupTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSqlVirtualMachineGroupCreate()
        {
            RunPowerShellTest("Test-CreateSqlVirtualMachineGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSqlVirtualMachineGroupGet()
        {
            RunPowerShellTest("Test-GetSqlVirtualMachineGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSqlVirtualMachineGroupUpdate()
        {
            RunPowerShellTest("Test-UpdateSqlVirtualMachineGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSqlVirtualMachineGroupRemove()
        {
            RunPowerShellTest("Test-RemoveSqlVirtualMachineGroup");
        }
    }
}
