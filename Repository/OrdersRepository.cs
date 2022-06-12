using Microsoft.EntityFrameworkCore;
using pharmacyManagementServiceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Repository
{
    public class OrdersRepository :IOrdersRepository
    {
        private readonly PharmacyManagementSystemContext _context;
        public OrdersRepository(PharmacyManagementSystemContext context)
        {
            _context = context;
        }

        public Order Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.Include(ordr => ordr.User).ToList();
            //return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }


        public IEnumerable<Order> GetOrders(int id)
        {
            var order = _context.Orders.Where(u => u.UserId == id).ToList();
            return order;

        }
    }
}
