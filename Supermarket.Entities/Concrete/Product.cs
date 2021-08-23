using Supermarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Supermarket.Entities.Concrete
{
    public class Product: IEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public short Stock { get; set; }
        [Required]
        public decimal Price { get; set; }
       
    }
}
