using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string token { get; set; }
    }
}