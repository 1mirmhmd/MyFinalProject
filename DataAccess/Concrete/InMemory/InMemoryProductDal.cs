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
        List<Product> products;
        public InMemoryProductDal()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=2, ProductName="Cup", UnitPrice=20, UnitsInStock=45},
                new Product{ProductId=2, CategoryId=4, ProductName="Keyboard", UnitPrice=20, UnitsInStock=50 },
                new Product{ProductId=3, CategoryId=1, ProductName="Freezer", UnitPrice=5000, UnitsInStock=5 },


            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
