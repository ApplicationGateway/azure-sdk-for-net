//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//


namespace Microsoft.WindowsAzure
{
    using System;
    using Microsoft.WindowsAzure.Common;
    using Microsoft.WindowsAzure.Common.Internals;
    using Microsoft.WindowsAzure.Management.ApplicationGateway;

    public static class ApplicationGatewayManagementDiscoveryExtensions
    {
        public static ApplicationGatewayManagementClient CreateApplicationGatewayManagementClient(this CloudClients clients, SubscriptionCloudCredentials credentials)
        {
            return new ApplicationGatewayManagementClient(credentials);
        }

        public static ApplicationGatewayManagementClient CreateApplicationGatewayManagementClient(this CloudClients clients, SubscriptionCloudCredentials credentials, Uri baseUri)
        {
            return new ApplicationGatewayManagementClient(credentials, baseUri);
        }

        public static ApplicationGatewayManagementClient CreateApplicationGatewayManagementClient(this CloudClients clients)
        {
            return ConfigurationHelper.CreateFromSettings<ApplicationGatewayManagementClient>(ApplicationGatewayManagementClient.Create);
        }
    }
}

namespace Microsoft.WindowsAzure.Management.ApplicationGateway
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using Microsoft.WindowsAzure.Common.Internals;

    public partial class ApplicationGatewayManagementClient
    {
        public static ApplicationGatewayManagementClient Create(IDictionary<string, object> settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            SubscriptionCloudCredentials credentials = ConfigurationHelper.GetCredentials<SubscriptionCloudCredentials>(settings);

            Uri baseUri = ConfigurationHelper.GetUri(settings, "BaseUri", false);

            return baseUri != null ?
                new ApplicationGatewayManagementClient(credentials, baseUri) :
                new ApplicationGatewayManagementClient(credentials);
        }

        public override ApplicationGatewayManagementClient WithHandler(DelegatingHandler handler)
        {
            return (ApplicationGatewayManagementClient)WithHandler(new ApplicationGatewayManagementClient(), handler);
        }
    }
}
