using Supermarket.Entities.Concrete;
using System.Collections.Generic;

namespace Supermarket.Web.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}