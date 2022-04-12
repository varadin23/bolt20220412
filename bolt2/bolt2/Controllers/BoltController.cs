using bolt2.Models;
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

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return bolttServices.GetProduct();
        }

       
        [HttpGet]
        [Route("{id}")]
        public Product GetProduct(int id)
        {
           return (Product)bolttServices.GetProduct(id);
        }
    }
}
