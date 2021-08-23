using Supermarket.Entities.Concrete;
using System.Collections.Generic;

namespace Supermarket.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
