﻿using System.Collections.Generic;
using System.Security.Claims;

namespace FT.Common.Authentication
{
    public class JsonWebTokenPayload
    {
        public string Subject { get; set; }
        public string Role { get; set; }
        public long Expires { get; set; }
        public IDictionary<string, string> Claims { get; set; }
    }
}