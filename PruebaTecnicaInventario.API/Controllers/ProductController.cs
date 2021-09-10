using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaInventario.Core.Interfaces;
using PruebaTecnicaInventario.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PruebaTecnicaInventario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            await _productService.InsertProduct(product);
            return Ok(product);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("{id}")]
        public async Task<IActionResult> getProduct(int id)
        {
            var product = await _productService.GetProduct(id);
            return Ok(product);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet]
        public IActionResult GetPorducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Product product)
        {
            var response = await _productService.UpdateProduct(product);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _productService.DeleteProduct(id);
            return Ok(response);
        }
    }
}
