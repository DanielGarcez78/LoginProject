using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP.Web.Models
{
    public class LoginViewModel
    {
        [FromForm]
        public string Nome { get; set; }

        [FromForm]
        public string Senha { get; set; }
    }
}
