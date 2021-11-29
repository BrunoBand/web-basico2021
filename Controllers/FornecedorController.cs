using AtacadoAPI.Data;
using AtacadoAPI.Data.Dtos.Fornecedor;
using AtacadoAPI.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtacadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private ClienteContext _contextForn;
        private IMapper _mapperForn;

        public FornecedorController(ClienteContext context, IMapper mapper)
        {
            _contextForn = context;
            _mapperForn = mapper;
        }

        [HttpPost]
        public IActionResult AddFornecedor([FromBody] CreateFornecedorDto fornecedorDto)
        {
            Fornecedor fornecedor = _mapperForn.Map<Fornecedor>(fornecedorDto);
            _contextForn.Fornecedores.Add(fornecedor);
            _contextForn.SaveChanges();
            return CreatedAtAction(nameof(GetFornecedorById), new { Id = fornecedor.Id }, fornecedor);
        }

        [HttpGet]
        public IEnumerable<Fornecedor> GetFornecedores()
        {
            return _contextForn.Fornecedores;
        }

        [HttpGet("{id}")]
        public IActionResult GetFornecedorById(int id)
        {
            Fornecedor fornecedor = _contextForn.Fornecedores.FirstOrDefault(fornecedor => fornecedor.Id == id);

            if (fornecedor != null)
            {
                ReadFornecedorDto fornecedorDto = _mapperForn.Map<ReadFornecedorDto>(fornecedor);
                return Ok(fornecedorDto);
            }
            return NotFound();
        }

        [HttpGet("consulta/{cnpj}")]
        public IActionResult GetFornecedorByCnpj(String cnpj)
        {
            Fornecedor fornecedor = _contextForn.Fornecedores.FirstOrDefault(fornecedor => fornecedor.Cnpj == cnpj);
            if (fornecedor != null)
            {
                return Ok(fornecedor);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFornecedor(int id, [FromBody] UpdateFornecedorDto fornecedorDto)
        {
            Fornecedor fornecedor = _contextForn.Fornecedores.FirstOrDefault(fornecedor => fornecedor.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            _mapperForn.Map(fornecedorDto, fornecedor);
            _contextForn.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFornecedor(int id)
        {
            Fornecedor fornecedor = _contextForn.Fornecedores.FirstOrDefault(fornecedor => fornecedor.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            _contextForn.Remove(fornecedor);
            _contextForn.SaveChanges();
            return NoContent();
        }
    }
}
