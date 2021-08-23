using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Web.Models
{
    public class CartListViewModel
    {
        public Cart Cart { get; internal set; }
    }
}
