// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace IdentityServerHost.Quickstart.UI
{
    public class VerifyCodeViewModel
    {
        [Required]
        public string Code { get; set; }
        public string Username { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;
    }
}