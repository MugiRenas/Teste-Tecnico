using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Linq;
using ClassLibrary2;

namespace WebApplication1.Controllers
{
    public class ProductsCategoriesController : ApiController
    {
        public IEnumerable<Products1> GetProducts()
        {
            using(ProductsDBEntities entities = new ProductsDBEntities())
            {
                return entities.Products.ToList();
            }
        }

        public Products1 GetProduct(int id)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                return dbContext.Products.FirstOrDefault(e => e.ID == id);
            }
        }

        public IEnumerable<Category1> GetCategories()
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                return entities.Categories.ToList();
            }
        }

        public Category1 GetCategory(int id)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                return dbContext.Categories.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
