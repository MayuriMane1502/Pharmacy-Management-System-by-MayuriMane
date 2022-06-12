using pharmacyManagementServiceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Repository
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> GetAll();
        Order Create(Order order);

        IEnumerable<Order> GetOrders(int id);
    }
}
