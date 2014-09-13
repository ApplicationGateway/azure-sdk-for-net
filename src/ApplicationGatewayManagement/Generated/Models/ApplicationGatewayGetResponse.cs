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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.ApplicationGateway.Models;

namespace Microsoft.WindowsAzure.Management.ApplicationGateway.Models
{
    /// <summary>
    /// The response body contains details of the application gateway.
    /// </summary>
    public partial class ApplicationGatewayGetResponse : OperationResponse
    {
        private string _description;
        
        /// <summary>
        /// Optional. User supplied description of the gateway
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _dnsName;
        
        /// <summary>
        /// Optional. DNS name for the gateay.
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }
        
        private string _gatewaySize;
        
        /// <summary>
        /// Optional. The size of each gateway instance.
        /// </summary>
        public string GatewaySize
        {
            get { return this._gatewaySize; }
            set { this._gatewaySize = value; }
        }
        
        private uint _instanceCount;
        
        /// <summary>
        /// Optional. The number of instances of this gateway.
        /// </summary>
        public uint InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The friendly name of the gateway
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. The provisioning state of the gateway.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private SubnetCollection _subnets;
        
        /// <summary>
        /// Optional. Subnets in the vnet to which the gateway belongs.
        /// </summary>
        public SubnetCollection Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }
        
        private string _vip;
        
        /// <summary>
        /// Optional. The Virtual IP of the gateway.
        /// </summary>
        public string Vip
        {
            get { return this._vip; }
            set { this._vip = value; }
        }
        
        private string _vnetName;
        
        /// <summary>
        /// Optional. The VNET to which the gateway belongs.
        /// </summary>
        public string VnetName
        {
            get { return this._vnetName; }
            set { this._vnetName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayGetResponse
        /// class.
        /// </summary>
        public ApplicationGatewayGetResponse()
        {
        }
    }
}