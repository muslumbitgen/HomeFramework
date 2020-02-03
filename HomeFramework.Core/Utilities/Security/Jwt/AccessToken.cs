using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public string Expiration { get; set; }
    }
}
