using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AtacadoAPI.Data.Dtos.Venda
{
    public class CreateVendaDto
    {
        [Required(ErrorMessage = "Quantidade é obrigatória")]
        public Double Quantidade { get; set; }
        [Required(ErrorMessage = "Data é obrigatória")]
        public String Data { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
    }
}
