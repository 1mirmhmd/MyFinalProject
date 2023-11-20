using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=2, ProductName="Cup", UnitPrice=20, UnitsInStock=45},
                new Product{ProductId=2, CategoryId=4, ProductName="Keyboard", UnitPrice=20, UnitsInStock=50 },
                new Product{ProductId=3, CategoryId=1, ProductName="Freezer", UnitPrice=5000, UnitsInStock=5 },
                new Product{ProductId=4, CategoryId=3, ProductName="Book", UnitPrice=30, UnitsInStock=78 }
            };
        }
        public void Add(Product product)
        {

            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // Eğer aşağıdaki linq kodu olmasaydı bu kod yazılırdı
            /*Product productToDelete=null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }*/

            // Linq kodu 

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // => lambda işareti
            _products.Remove(productToDelete);

            // LINQ (Language Integrated Query)
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // => lambda işareti
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
