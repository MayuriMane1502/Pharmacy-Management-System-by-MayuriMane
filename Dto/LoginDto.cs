using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Dto
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string UserPassword { get; set; }
    }
}
