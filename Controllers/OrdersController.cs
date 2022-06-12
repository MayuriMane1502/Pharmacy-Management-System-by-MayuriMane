using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacyManagementServiceWebApi.Dto;
using pharmacyManagementServiceWebApi.Models;
using pharmacyManagementServiceWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pharmacyManagementServiceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository orderRepository)
        {
            _ordersRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var order = _ordersRepository.GetAll();
            return Ok(order);
        }
        [HttpPost]
        public IActionResult Post(AddOrders addOrder)
        {
            var order = new Order
            {
                OrderId = addOrder.OrderId,
                UserId = addOrder.UserId,
            };
            var newOrder = _ordersRepository.Create(order);
            return Created("Sucess", newOrder);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var order = _ordersRepository.GetOrders(id);

            return new OkObjectResult(order);
        }
    }
}
