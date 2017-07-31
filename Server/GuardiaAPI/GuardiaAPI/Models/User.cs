using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuardiaAPI.Models
{
    public class User
    {
        public string UniqueKey { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}