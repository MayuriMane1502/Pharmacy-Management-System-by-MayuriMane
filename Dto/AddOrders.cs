using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Dto
{
    public class AddOrders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
    }
}
