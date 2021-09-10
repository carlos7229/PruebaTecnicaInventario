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
    public class StockController : Controller
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Stock stock)
        {
            await _stockService.InsertStock(stock);
            return Ok(stock);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("{id}")]
        public async Task<IActionResult> getStock(int id)
        {
            var stock = await _stockService.GetStock(id);
            return Ok(stock);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet]
        public IActionResult getAllStock()
        {
            var stock = _stockService.GetAllStock();
            return Ok(stock);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Stock stock)
        {
            var response = await _stockService.UpdateStock(stock);
            return Ok(response);
        }
    }
}
