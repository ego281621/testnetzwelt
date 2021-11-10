using System;
using System.Collections.Generic;

namespace Netzwelt.Models.Response
{
    public class LoginResponseModel
    {
        public string username { get; set; }

        public string displayName { get; set; }

        public List<string> roles { get; set; }
        public bool success { get; set; }
        public string message { get; set; }

    }
}
