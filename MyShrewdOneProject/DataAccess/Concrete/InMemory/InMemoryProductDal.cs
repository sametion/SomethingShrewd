using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // as if coming from any database. we re just simulating
                _products = new List<Product>() { 
                new Product{CategoryId=1,ProductId=1,ProductName="cup",UnitPrice=15,UnitsInStock=25},
                new Product{CategoryId=2,ProductId=1,ProductName="camera",UnitPrice=120,UnitsInStock=25},
                new Product{CategoryId=3,ProductId=2,ProductName="table",UnitPrice=150,UnitsInStock=50},
                new Product{CategoryId=4,ProductId=1,ProductName="plate",UnitPrice=12,UnitsInStock=65},
                new Product{CategoryId=5,ProductId=2,ProductName="spoon",UnitPrice=11,UnitsInStock=75},
                };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);  //lINQ
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p=>p.CategoryId==categoryID).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); 
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitsInStock= product.UnitsInStock;
        }
    }
}
