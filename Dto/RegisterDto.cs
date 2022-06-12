using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Dto
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Contact { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
    }
}
