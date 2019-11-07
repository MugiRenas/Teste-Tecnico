using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary2;

namespace WebApplication1.Controllers
{
    public class ProductsCategoriesController : ApiController
    {
        public IEnumerable<Products1> GetProducts()
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
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

        public void PostProduct([FromBody] Products1 product)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }

        public void PostCategory([FromBody] Category1 category)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
            }
        }
        public void PutProduct(int id, [FromBody]Products1 product)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                var entity = dbContext.Products.FirstOrDefault(e => e.ID == id);
                entity.Name = product.Name;
                entity.Price = product.Price;
                entity.Category_Id = product.Category_Id;
                dbContext.SaveChanges();
            }
        }

        public void PutCategory(int id, [FromBody]Category1 category)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                var entity = dbContext.Categories.FirstOrDefault(e => e.ID == id);
                entity.Name = category.Name;
                dbContext.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                dbContext.Products.Remove(dbContext.Products.FirstOrDefault(e => e.ID == id));
                dbContext.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            using (ProductsDBEntities dbContext = new ProductsDBEntities())
            {
                dbContext.Categories.Remove(dbContext.Categories.FirstOrDefault(e => e.ID == id));
                dbContext.SaveChanges();
            }
        }

    }
}
