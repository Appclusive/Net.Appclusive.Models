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

namespace Net.Appclusive.Models.Constants
{
    public static class Inventory
    {
        public static class OrganisationalUnit
        {
            public const string NAME_NAME = "Net.Appclusive.Models.Constants.Inventory.OrganisationalUnit.Name";
            public const string NAME_DEFAULT = "OrganisationalUnit";
            public const int NAME_MIN = 1;
            public const int NAME_MAX = 1024;

            public const string DESCRIPTION_NAME = "Net.Appclusive.Models.Constants.Inventory.OrganisationalUnit.Description";
            public const string DESCRIPTION_DEFAULT = "OrganisationalUnit";
            public const int DESCRIPTION_MIN = 0;
            public const int DESCRIPTION_MAX = 4096;
        }
    }
}
