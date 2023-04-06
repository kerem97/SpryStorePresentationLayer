using Microsoft.EntityFrameworkCore;
using SpryStoreDataAccessLayer.Abstract;
using SpryStoreDataAccessLayer.Concrete;
using SpryStoreDataAccessLayer.Repositories;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetLast4Product()
        {
            var context = new Context();
            return context.Products.Take(4).OrderByDescending(x => x.ProductID).ToList();
        }

        public List<Product> GetProductListWithCategory()
        {
            var context = new Context();
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}
