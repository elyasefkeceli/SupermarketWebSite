using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Business.Abstract;
using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return Ok(product);
        }
        [HttpPost]
        [Route("update")]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }
        [HttpPost]
        [Route("delete")]
        public IActionResult Delete(int produckId)
        {
            _productService.Delete(produckId);
            return Ok(produckId);
        }
    }
}
