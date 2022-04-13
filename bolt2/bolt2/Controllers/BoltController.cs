using bolt2.Models;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolt2.Controllers
{
    [Controller]
    [Route("[Controller]")]
    public class BoltController : Controller
    {
        private readonly BolttServices bolttServices;
        public BoltController(BolttServices bolttServices)
        {
            this.bolttServices = bolttServices;
        }

        //[HttpGet]
        //public IEnumerable<Product> GetProducts(int customerID)
        //{
        //    return Context.OrderProduct.Where(op => op.Order.CustomerId).Select(op => op.Product);
        //}

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Product> GetProduct(int id)
        {
           return bolttServices.GetProducts(id);
        }
      
    }
}
