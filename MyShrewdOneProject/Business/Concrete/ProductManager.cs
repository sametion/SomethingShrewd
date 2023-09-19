using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDAl;
        public ProductManager(IProductDal productDal)
        {
            _productDAl = productDal; 
        }
        public List<Product> GetAll()
        {
            return _productDAl.GetAll();
        }
    }
}
