using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week7Capstone.Models;

namespace Week7Capstone.Controllers
{
    public class NorthwindController : ApiController
    {
        [HttpGet]
        public List<ProductArray> product()
        {
            northwindEntities ORM = new northwindEntities();

            List<ProductArray> products = new List<ProductArray>();

            foreach (var item in ORM.Products)
            {
                ProductArray temp = new ProductArray();

                temp.ProductID = item.ProductID;
                temp.ProductName = item.ProductName;
                products.Add(temp);
            }

            return products;
        }

        [HttpGet]
        public Product product(int id)
        {
            northwindEntities ORM = new northwindEntities();

            List<Product> products = ORM.Products.Where(x => x.ProductID == id).ToList();

            return products[0];
        }
    }
}