using Supermarket.Core.DataAccess.EntityFramework;
using Supermarket.DataAccess.Abstract;
using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,SupermarketWebContext> ,IProductDal
    {
    }
}
