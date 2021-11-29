using AtacadoAPI.Data;
using AtacadoAPI.Data.Dtos.Compra;
using AtacadoAPI.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AtacadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {
        private ClienteContext _contextCompra;
        private IMapper _mapperCompra;

        public CompraController(ClienteContext context, IMapper mapper)
        {
            _contextCompra = context;
            _mapperCompra = mapper;
        }
        [HttpPost]
        public IActionResult AddCompra([FromBody] CreateCompraDto compraDto)
        {
            Compra compra = _mapperCompra.Map<Compra>(compraDto);
            _contextCompra.Compras.Add(compra);
            _contextCompra.SaveChanges();
            return CreatedAtAction(nameof(GetCompraById), new { Id = compra.Id }, compra);
        }

        [HttpGet]
        public IEnumerable<Compra> GetCompras()
        {
            return _contextCompra.Compras;
        }

        [HttpGet("{id}")]
        public IActionResult GetCompraById(int id)
        {
            Compra compra = _contextCompra.Compras.FirstOrDefault(compra => compra.Id == id);
            if (compra != null)
            {
                ReadCompraDto compraDto = _mapperCompra.Map<ReadCompraDto>(compra);
                return Ok(compraDto);
            }
            return NotFound();
        }
    }
}
