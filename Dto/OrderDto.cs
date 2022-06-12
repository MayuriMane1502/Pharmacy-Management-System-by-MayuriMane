using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Dto
{
    public class OrderDto
    {
        public int? DrugId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? OrderPrice { get; set; }
    }
}
