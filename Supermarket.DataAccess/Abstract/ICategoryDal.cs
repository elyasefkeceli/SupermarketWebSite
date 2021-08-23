using Supermarket.Core.DataAccess;
using Supermarket.Entities;
using Supermarket.Entities.Concrete;

namespace Supermarket.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
