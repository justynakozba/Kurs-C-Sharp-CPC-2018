using JustynaKozbaLab6.DataBase;
using JustynaKozbaLab6.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustynaKozbaLab6.Controllers
{
    public class OrdersController : ApiController
    {
        /// <summary>
        /// Wygenerowano automatycznie metody Web Api z funkcjami zapisu i odczytu
        /// </summary>
        /// <returns></returns>
        // GET: api/Orders
        public IEnumerable<OrderDto> Get()
        {
            using (var context = new DatabaseContext())
            {
                var orders = context.Order.ToList();
                return orders.Select(o => new OrderDto()
                {
                    Email = o.Email,
                    FirstName = o.FirstName,
                    LastName = o.LastName,
                    OrderId = o.OrderId
                });
            }
                
        }

        // GET: api/Orders/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
