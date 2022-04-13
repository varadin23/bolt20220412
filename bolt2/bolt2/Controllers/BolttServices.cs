using bolt2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bolt2.Controllers
{
    
    public class BolttServices
    {
        private boltContext context;
        public BolttServices(boltContext boltContext)
        {

            context = boltContext;
        }
        //internal IEnumerable<Class> GetAllbolt()
        //{
        //    throw new NotImplementedException();
        //}

        //internal Class GetBoltByEmail(int id)
        //{
        //    throw new NotImplementedException();
        //}
        internal IEnumerable<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<Product> GetProducts(int customerId,DateTime startDate)
        {
            //Adtok lekérése adatbázisból.(3 megoldás) sima lekérdezés
            // return context.OrderProducts.Where(op => op.Order.CustomerId == customerId).Select(op => op.Product);
            //return context.Customers.Where(c => c.Id == customerId).SelectMany(c => c.Orders).SelectMany(o => o.OrderProducts).Select(op => op.Product).ToHashSet();
            //return context.Products.Where(p => OrderProduct.Any(op => Order.customerId == customerId));

            //lekérdezés előtt hozzáadni
            // return context.Products.Where(p => OrderProduct.Any(op => Order.customerId == customerId && op.Order.CompletedAt > startDate));
            //return context.OrderProducts.Where(op => op.Order.CustomerId == customerId && op.Order.CompletedAt > startDate);
            //return context.Customers.Where(c => c.Id == customerId).SelectMany(c => c.Orders).Where(o => o.CompletedAt > startDate).SelectMany(o => OrderProduct).Select(op => op.Product);

        }
    }
}