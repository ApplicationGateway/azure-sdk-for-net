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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Represents the properties of a website.
    /// </summary>
    public partial class WebSiteProperties
    {
        private bool _adminEnabled;
        
        /// <summary>
        /// Optional. Read-only. This value is always true.
        /// </summary>
        public bool AdminEnabled
        {
            get { return this._adminEnabled; }
            set { this._adminEnabled = value; }
        }
        
        private WebSpaceAvailabilityState _availabilityState;
        
        /// <summary>
        /// Optional. The state of the availability of management information
        /// for the site. Possible values are Normal or Limited. Normal means
        /// that the site is running correctly and that management information
        /// for the site is available. Limited means that only partial
        /// management information for the site is available and that detailed
        /// site information is unavailable.
        /// </summary>
        public WebSpaceAvailabilityState AvailabilityState
        {
            get { return this._availabilityState; }
            set { this._availabilityState = value; }
        }
        
        private bool _enabled;
        
        /// <summary>
        /// Optional. true if the site is enabled; otherwise, false. Setting
        /// this value to false disables the site (takes the site off line).
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private IList<string> _enabledHostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains enabled hostnames for
        /// the site. By default, these are [SiteName].azurewebsites.net and
        /// [SiteName].scm.azurewebsites.net.
        /// </summary>
        public IList<string> EnabledHostNames
        {
            get
            {
                if (this._enabledHostNames == null)
                {
                    this._enabledHostNames = new System.Collections.Generic.List<string>();
                }
                return this._enabledHostNames;
            }
            set { this._enabledHostNames = value; }
        }
        
        /// <summary>
        /// Optional. An array of strings that contains enabled hostnames for
        /// the site. By default, these are [SiteName].azurewebsites.net and
        /// [SiteName].scm.azurewebsites.net.
        /// </summary>
        public IList<string> EnabledHostNamesValue
        {
            get { return this._enabledHostNames; }
            set { this._enabledHostNames = value; }
        }
        
        private IList<string> _hostNames;
        
        /// <summary>
        /// Optional. An array of strings that contains the public hostnames
        /// for the site, including custom domains. Important: When you add a
        /// custom domain in a PUT operation, be sure to include every
        /// hostname that you want for the web site. To delete a custom domain
        /// name in a PUT operation, include all of the hostnames for the site
        /// that you want to keep, but leave out the one that you wangt to
        /// delete.
        /// </summary>
        public IList<string> HostNames
        {
            get
            {
                if (this._hostNames == null)
                {
                    this._hostNames = new System.Collections.Generic.List<string>();
                }
                return this._hostNames;
            }
            set { this._hostNames = value; }
        }
        
        /// <summary>
        /// Optional. An array of strings that contains the public hostnames
        /// for the site, including custom domains. Important: When you add a
        /// custom domain in a PUT operation, be sure to include every
        /// hostname that you want for the web site. To delete a custom domain
        /// name in a PUT operation, include all of the hostnames for the site
        /// that you want to keep, but leave out the one that you wangt to
        /// delete.
        /// </summary>
        public IList<string> HostNamesValue
        {
            get { return this._hostNames; }
            set { this._hostNames = value; }
        }
        
        private IList<WebSiteProperties.WebSiteHostNameSslState> _hostNameSslStates;
        
        /// <summary>
        /// Optional. SSL states bound to the website.
        /// </summary>
        public IList<WebSiteProperties.WebSiteHostNameSslState> HostNameSslStates
        {
            get
            {
                if (this._hostNameSslStates == null)
                {
                    this._hostNameSslStates = new System.Collections.Generic.List<Microsoft.Azure.Management.WebSites.Models.WebSiteProperties.WebSiteHostNameSslState>();
                }
                return this._hostNameSslStates;
            }
            set { this._hostNameSslStates = value; }
        }
        
        /// <summary>
        /// Optional. SSL states bound to the website.
        /// </summary>
        public IList<WebSiteProperties.WebSiteHostNameSslState> HostNameSslStatesValue
        {
            get { return this._hostNameSslStates; }
            set { this._hostNameSslStates = value; }
        }
        
        private DateTime _lastModifiedTimeUtc;
        
        /// <summary>
        /// Optional. A dateTime value that contains, in Coordinated Universal
        /// Time, the last time the web site was modified.
        /// </summary>
        public DateTime LastModifiedTimeUtc
        {
            get { return this._lastModifiedTimeUtc; }
            set { this._lastModifiedTimeUtc = value; }
        }
        
        private WebSiteProperties.SiteProperties _properties;
        
        /// <summary>
        /// Optional. Contains AppSettings, Metadata, and Properties for a site.
        /// </summary>
        public WebSiteProperties.SiteProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets resource provisioning state.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _repositorySiteName;
        
        /// <summary>
        /// Optional. The name of the repository web site.
        /// </summary>
        public string RepositorySiteName
        {
            get { return this._repositorySiteName; }
            set { this._repositorySiteName = value; }
        }
        
        private WebSiteRuntimeAvailabilityState _runtimeAvailabilityState;
        
        /// <summary>
        /// Optional. Possible values are Normal, Degraded, or NotAvailable.
        /// Normal: the web site is running correctly. Degraded: the web site
        /// is running temporarily in a degraded mode (typically with less
        /// memory and a shared instance.) Not Available: due to an unexpected
        /// issue, the site has been excluded from provisioning. This
        /// typically occurs only for free sites.
        /// </summary>
        public WebSiteRuntimeAvailabilityState RuntimeAvailabilityState
        {
            get { return this._runtimeAvailabilityState; }
            set { this._runtimeAvailabilityState = value; }
        }
        
        private string _serverFarm;
        
        /// <summary>
        /// Optional. Name of a Web Hosting Plan (Server Farm) that this site
        /// belongs to.
        /// </summary>
        public string ServerFarm
        {
            get { return this._serverFarm; }
            set { this._serverFarm = value; }
        }
        
        private SkuOptions _sku;
        
        /// <summary>
        /// Optional. SKU of a Web Hosting Plan (Server Farm) that this site
        /// belongs to.
        /// </summary>
        public SkuOptions Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private WebSiteState _state;
        
        /// <summary>
        /// Optional. A string that describes the state of the web site.
        /// Possible values are Stopped or Running.
        /// </summary>
        public WebSiteState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private IList<string> _trafficManagerHostNames;
        
        /// <summary>
        /// Optional. An array of strings that contain the traffic manager
        /// hostnames.
        /// </summary>
        public IList<string> TrafficManagerHostNames
        {
            get
            {
                if (this._trafficManagerHostNames == null)
                {
                    this._trafficManagerHostNames = new System.Collections.Generic.List<string>();
                }
                return this._trafficManagerHostNames;
            }
            set { this._trafficManagerHostNames = value; }
        }
        
        /// <summary>
        /// Optional. An array of strings that contain the traffic manager
        /// hostnames.
        /// </summary>
        public IList<string> TrafficManagerHostNamesValue
        {
            get { return this._trafficManagerHostNames; }
            set { this._trafficManagerHostNames = value; }
        }
        
        private Uri _uri;
        
        /// <summary>
        /// Optional. Direct URL to the web site endpoint on Windows Azure Web
        /// Sites, including the subscription ID, webspace name, and site name.
        /// </summary>
        public Uri Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        private WebSiteUsageState _usageState;
        
        /// <summary>
        /// Optional. Possible values are Normal or Exceeded. If any quota is
        /// exceeded, the UsageState value changes to Exceeded and the site
        /// goes off line.
        /// </summary>
        public WebSiteUsageState UsageState
        {
            get { return this._usageState; }
            set { this._usageState = value; }
        }
        
        private string _webSpace;
        
        /// <summary>
        /// Optional. The name of the webspace in which the web site is
        /// located. This property is read-only.
        /// </summary>
        public string WebSpace
        {
            get { return this._webSpace; }
            set { this._webSpace = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteProperties class.
        /// </summary>
        public WebSiteProperties()
        {
        }
        
        public partial class SiteProperties
        {
            private IDictionary<string, string> _appSettings;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain application
            /// settings for a site.
            /// </summary>
            public IDictionary<string, string> AppSettings
            {
                get
                {
                    if (this._appSettings == null)
                    {
                        this._appSettings = new System.Collections.Generic.Dictionary<string, string>();
                    }
                    return this._appSettings;
                }
                set { this._appSettings = value; }
            }
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain application
            /// settings for a site.
            /// </summary>
            public IDictionary<string, string> AppSettingsValue
            {
                get { return this._appSettings; }
                set { this._appSettings = value; }
            }
            
            private IDictionary<string, string> _metadata;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain metadata
            /// information for a site.
            /// </summary>
            public IDictionary<string, string> Metadata
            {
                get
                {
                    if (this._metadata == null)
                    {
                        this._metadata = new System.Collections.Generic.Dictionary<string, string>();
                    }
                    return this._metadata;
                }
                set { this._metadata = value; }
            }
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain metadata
            /// information for a site.
            /// </summary>
            public IDictionary<string, string> MetadataValue
            {
                get { return this._metadata; }
                set { this._metadata = value; }
            }
            
            private IDictionary<string, string> _properties;
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain properties for
            /// a site.
            /// </summary>
            public IDictionary<string, string> Properties
            {
                get
                {
                    if (this._properties == null)
                    {
                        this._properties = new System.Collections.Generic.Dictionary<string, string>();
                    }
                    return this._properties;
                }
                set { this._properties = value; }
            }
            
            /// <summary>
            /// Optional. A set of name/value pairs that contain properties for
            /// a site.
            /// </summary>
            public IDictionary<string, string> PropertiesValue
            {
                get { return this._properties; }
                set { this._properties = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the SiteProperties class.
            /// </summary>
            public SiteProperties()
            {
            }
        }
        
        /// <summary>
        /// SSL states bound to a website.
        /// </summary>
        public partial class WebSiteHostNameSslState
        {
            private string _ipBasedSslResult;
            
            /// <summary>
            /// Optional. The IP based SSL result
            /// </summary>
            public string IpBasedSslResult
            {
                get { return this._ipBasedSslResult; }
                set { this._ipBasedSslResult = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The URL of the web site.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private WebSiteSslState _sslState;
            
            /// <summary>
            /// Optional. The SSL state. Possible values are Disabled,
            /// SniEnabled, or IpBasedEnabled.
            /// </summary>
            public WebSiteSslState SslState
            {
                get { return this._sslState; }
                set { this._sslState = value; }
            }
            
            private string _thumbprint;
            
            /// <summary>
            /// Optional. A string that contains the thumbprint of the SSL
            /// certificate.
            /// </summary>
            public string Thumbprint
            {
                get { return this._thumbprint; }
                set { this._thumbprint = value; }
            }
            
            private bool? _toUpdate;
            
            /// <summary>
            /// Optional. Boolean value indicating if it should be updated
            /// </summary>
            public bool? ToUpdate
            {
                get { return this._toUpdate; }
                set { this._toUpdate = value; }
            }
            
            private bool? _toUpdateIpBasedSsl;
            
            /// <summary>
            /// Optional. Boolean value indicating if it should be updated
            /// based on ssl
            /// </summary>
            public bool? ToUpdateIpBasedSsl
            {
                get { return this._toUpdateIpBasedSsl; }
                set { this._toUpdateIpBasedSsl = value; }
            }
            
            private string _virtualIP;
            
            /// <summary>
            /// Optional. String. The IP address assigned to the hostname if
            /// the hostname uses IP SSL.
            /// </summary>
            public string VirtualIP
            {
                get { return this._virtualIP; }
                set { this._virtualIP = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSiteHostNameSslState class.
            /// </summary>
            public WebSiteHostNameSslState()
            {
            }
        }
    }
}
