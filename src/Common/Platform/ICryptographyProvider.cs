﻿//
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

using System;
using System.Collections.Generic;

namespace Microsoft.WindowsAzure.Common.Platform
{
    /// <summary>
    /// Defines cryptographic methods.
    /// </summary>
    public interface ICryptographyProvider
    {
        /// <summary>
        /// Computes SHA256 hash from key and data.
        /// </summary>
        /// <param name="key">Key to use as hash salt.</param>
        /// <param name="data">Data to hash.</param>
        /// <returns>Hash value.</returns>
        byte[] ComputeHmacSha256Hash(byte[] key, byte[] data);
    }
}
