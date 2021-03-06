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

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// Sku parameters supplied to the create redis operation.
    /// </summary>
    public partial class Sku
    {
        private int _capacity;
        
        /// <summary>
        /// Required. What size of redis cache to deploy. Valid values: for C
        /// family (0, 1, 2, 3, 4, 5, 6), for P family (1, 2, 3, 4)
        /// </summary>
        public int Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }
        
        private string _family;
        
        /// <summary>
        /// Required. Which family to use. Valid values: (C, P)
        /// </summary>
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. What type of redis cache to deploy. Valid values: (Basic,
        /// Standard, Premium)
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Sku class with required arguments.
        /// </summary>
        public Sku(string name, string family, int capacity)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (family == null)
            {
                throw new ArgumentNullException("family");
            }
            this.Name = name;
            this.Family = family;
            this.Capacity = capacity;
        }
    }
}
