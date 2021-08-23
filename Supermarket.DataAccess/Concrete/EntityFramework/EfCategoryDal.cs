using Supermarket.Core.DataAccess.EntityFramework;
using Supermarket.DataAccess.Abstract;
using Supermarket.Entities.Concrete;

namespace Supermarket.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, SupermarketWebContext>, ICategoryDal
    {
    }
}
