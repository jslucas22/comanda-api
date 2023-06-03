using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using comanda_backend.Business.Services.Abstractions.Products;
using comanda_backend.Business.Services.Products;
using comanda_backend.Domain.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace comanda_backend.Controllers
{
    public class ProductController : Controller
    {
        #region ..:: Variables ::..

        private ILogger<ProductController> _logger;
        private IProductService _service;

        #endregion

        #region ..:: Constructor ::..

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            _service = new ProductService();
        }

        #endregion

        #region ..:: Routes ::..

        [HttpGet("products")]
        public IActionResult Get()
        {
            return Ok(
                _service.Get()
                );
        }

        [HttpGet("product/{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(
                _service.Get(id)
                );
        }

        [HttpPost("product")]
        public IActionResult Post(ProductsModel product)
        {
            _service.Insert(product);
            return Ok();
        }

        [HttpPatch("product/{id}")]
        public IActionResult Patch(ProductsModel product)
        {
            _service.Update(product);
            return Ok();        
        }

        [HttpDelete("product/{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return NoContent();
        }

        #endregion
    }
}

