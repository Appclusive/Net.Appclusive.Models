/**
 * Copyright 2017 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Net.Appclusive.Public.Engine;

namespace Net.Appclusive.Models.V001
{
    [ExecutionType(ExecutionType.CSharpScript)]
    public class OrganisationalUnit : BaseModel
    {
        private static readonly Lazy<StateMachine> _stateMachine = new Lazy<StateMachine>(() =>
            StateMachineBuilder
                .For<OrganisationalUnit>()
                .GetStateMachine()
        );

        public override StateMachine GetStateMachine()
        {
            return _stateMachine.Value;
        }

        [AttributeName(Constants.Inventory.OrganisationalUnit.NAME_NAME)]
        [Required]
        [DefaultValue(Constants.Inventory.OrganisationalUnit.NAME_DEFAULT)]
        [StringLength(Constants.Inventory.OrganisationalUnit.NAME_MAX, MinimumLength = Constants.Inventory.OrganisationalUnit.NAME_MIN)]
        public string Name { get; set; }

        [AttributeName(Constants.Inventory.OrganisationalUnit.DESCRIPTION_NAME)]
        [DefaultValue(Constants.Inventory.OrganisationalUnit.DESCRIPTION_DEFAULT)]
        [StringLength(Constants.Inventory.OrganisationalUnit.DESCRIPTION_MAX, MinimumLength = Constants.Inventory.OrganisationalUnit.DESCRIPTION_MIN)]
        public string Description { get; set; }

        public class Edit : BaseModelAction
        {
            [AttributeName(Constants.Inventory.OrganisationalUnit.NAME_NAME)]
            [Required]
            [StringLength(Constants.Inventory.OrganisationalUnit.NAME_MAX, MinimumLength = Constants.Inventory.OrganisationalUnit.NAME_MIN)]
            public string Name { get; set; }

            [AttributeName(Constants.Inventory.OrganisationalUnit.DESCRIPTION_NAME)]
            [StringLength(Constants.Inventory.OrganisationalUnit.DESCRIPTION_MAX, MinimumLength = Constants.Inventory.OrganisationalUnit.DESCRIPTION_MIN)]
            public string Description { get; set; }
        }
    }
}
