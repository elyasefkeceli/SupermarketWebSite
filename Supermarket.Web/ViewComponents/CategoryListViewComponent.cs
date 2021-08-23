using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Supermarket.Business.Abstract;
using Supermarket.Entities.Concrete;
using Supermarket.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Web.ViewComponents
{
    public class CategoryListViewComponent :ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
