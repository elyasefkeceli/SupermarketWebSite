using Supermarket.Business.Abstract;
using Supermarket.DataAccess.Abstract;
using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
