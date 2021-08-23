using Supermarket.Core.DataAccess;
using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
    }
}
