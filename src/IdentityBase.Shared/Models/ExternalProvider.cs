// Copyright (c) Russlan Akiev. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityBase.Models
{
    public class ExternalProvider
    {
        public string DisplayName { get; set; }

        /// <summary>
        /// Provider name if you like
        /// </summary>
        public string AuthenticationScheme { get; set; }
    }
}
