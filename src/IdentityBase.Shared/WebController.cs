// Copyright (c) Russlan Akiev. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityBase.Mvc
{
    using IdentityServer4.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Localization;
    using Microsoft.Extensions.Logging;

    public abstract class WebController : Controller
    {
        public IStringLocalizer Localizer { get; set; }
        public ILogger Logger { get; set; }
        public IIdentityServerInteractionService InteractionService { get; set; }
        public IdentityBaseContext IdentityBaseContext { get; set; }
    }
}