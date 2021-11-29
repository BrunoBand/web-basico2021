using AtacadoAPI.Data;
using AtacadoAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AtacadoAPI.Data.Dtos.Produto;

namespace AtacadoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ClienteContext _contextProd;
        private IMapper _mapperProd;

        public ClienteContext Context { get => _contextProd; set => _contextProd = value; }

        public ProdutoController(ClienteContext contextProd, IMapper mapper)
        {
            _contextProd = contextProd;
            _mapperProd = mapper;
        }

        [HttpPost]
        public IActionResult AddProduto([FromBody] CreateProdutoDto produtoDto)
        {
            Produto produto = _mapperProd.Map<Produto>(produtoDto);
            _contextProd.Produtos.Add(produto);
            _contextProd.SaveChanges();
            return CreatedAtAction(nameof(GetProdutoById), new { Id = produto.Id }, produto);
        }

        [HttpGet]
        public IEnumerable<Produto> GetProdutos()
        {
            return _contextProd.Produtos;
        }

        [HttpGet("{id}")]
        public IActionResult GetProdutoById(int id)
        {
            Produto produto = _contextProd.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapperProd.Map<ReadProdutoDto>(produto);
                return Ok(produto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
        {
            Produto produto = _contextProd.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _mapperProd.Map(produtoDto, produto);
            _contextProd.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            Produto produto = _contextProd.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            _contextProd.Remove(produto);
            _contextProd.SaveChanges();
            return NoContent();
        }
    }
}

