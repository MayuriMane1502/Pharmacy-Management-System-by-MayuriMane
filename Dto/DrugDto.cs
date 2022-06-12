using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Dto
{
    public class DrugDto
    {
        public string DrugName { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? ExpiryDate { get; set; } = DateTime.Now;
    }
}
