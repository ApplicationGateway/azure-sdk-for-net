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
using Microsoft.WindowsAzure;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The web site instance ids response.
    /// </summary>
    public partial class WebSiteInstanceIdsResponse : OperationResponse, IEnumerable<string>
    {
        private IList<string> _instanceIds;
        
        /// <summary>
        /// Optional. The identifiers of the currently running instances of the
        /// web site.
        /// </summary>
        public IList<string> InstanceIds
        {
            get
            {
                if (this._instanceIds == null)
                {
                    this._instanceIds = new System.Collections.Generic.List<string>();
                }
                return this._instanceIds;
            }
            set { this._instanceIds = value; }
        }
        
        /// <summary>
        /// Optional. The identifiers of the currently running instances of the
        /// web site.
        /// </summary>
        public IList<string> InstanceIdsValue
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteInstanceIdsResponse class.
        /// </summary>
        public WebSiteInstanceIdsResponse()
        {
        }
        
        /// <summary>
        /// Gets the sequence of InstanceIds.
        /// </summary>
        public IEnumerator<string> GetEnumerator()
        {
            return this.InstanceIdsValue.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of InstanceIds.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
