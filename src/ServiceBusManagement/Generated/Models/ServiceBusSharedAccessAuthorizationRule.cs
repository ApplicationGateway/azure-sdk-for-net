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
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// An authorization rule.
    /// </summary>
    public partial class ServiceBusSharedAccessAuthorizationRule
    {
        private string _claimType;
        
        /// <summary>
        /// Optional. The type of the claim.
        /// </summary>
        public string ClaimType
        {
            get { return this._claimType; }
            set { this._claimType = value; }
        }
        
        private string _claimValue;
        
        /// <summary>
        /// Optional. The value of the claim.
        /// </summary>
        public string ClaimValue
        {
            get { return this._claimValue; }
            set { this._claimValue = value; }
        }
        
        private DateTime _createdTime;
        
        /// <summary>
        /// Optional. The time at which the authorization rule was created.
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }
        
        private string _keyName;
        
        /// <summary>
        /// Optional. The name of the key that was used.
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }
        
        private DateTime _modifiedTime;
        
        /// <summary>
        /// Optional. The most recent time the rule was updated.
        /// </summary>
        public DateTime ModifiedTime
        {
            get { return this._modifiedTime; }
            set { this._modifiedTime = value; }
        }
        
        private string _primaryKey;
        
        /// <summary>
        /// Optional. The primary key that was used.
        /// </summary>
        public string PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }
        }
        
        private int _revision;
        
        /// <summary>
        /// Optional. The revision number for the rule.
        /// </summary>
        public int Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }
        
        private IList<AccessRight> _rights;
        
        /// <summary>
        /// Optional. The rights associated with the rule.
        /// </summary>
        public IList<AccessRight> Rights
        {
            get
            {
                if (this._rights == null)
                {
                    this._rights = new System.Collections.Generic.List<Microsoft.WindowsAzure.Management.ServiceBus.Models.AccessRight>();
                }
                return this._rights;
            }
            set { this._rights = value; }
        }
        
        /// <summary>
        /// Optional. The rights associated with the rule.
        /// </summary>
        public IList<AccessRight> RightsValue
        {
            get { return this._rights; }
            set { this._rights = value; }
        }
        
        private string _secondaryKey;
        
        /// <summary>
        /// Optional. The secondary key that was used.
        /// </summary>
        public string SecondaryKey
        {
            get { return this._secondaryKey; }
            set { this._secondaryKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusSharedAccessAuthorizationRule class.
        /// </summary>
        public ServiceBusSharedAccessAuthorizationRule()
        {
        }
    }
}
