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
    public class SaleController : Controller
    {
        private readonly ISaleService _SaleService;

        public SaleController(ISaleService SaleService)
        {
            _SaleService = SaleService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Sale Sale)
        {
            await _SaleService.InsertSale(Sale);
            return Ok(Sale);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("{id}")]
        public async Task<IActionResult> getSale(int id)
        {
            var Sale = await _SaleService.GetSale(id);
            return Ok(Sale);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet]
        public IActionResult getSales()
        {
            var Sale = _SaleService.GetSales();
            return Ok(Sale);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Sale Sale)
        {
            var response = await _SaleService.UpdateSale(Sale);
            return Ok(response);
        }
    }
}
