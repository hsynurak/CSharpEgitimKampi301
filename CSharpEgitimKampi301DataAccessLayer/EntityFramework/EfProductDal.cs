using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Conrete;
using CSharpEgitimKampi301DataAccessLayer.Abstract;
using CSharpEgitimKampi301DataAccessLayer.Context;
using CSharpEgitimKampi301DataAccessLayer.Repositories;

namespace CSharpEgitimKampi301DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x=> new Product 
            { 
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList();
            return values;
        }
    }
}
