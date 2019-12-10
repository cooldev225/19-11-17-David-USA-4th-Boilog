using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Biolog.Models {

  public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
