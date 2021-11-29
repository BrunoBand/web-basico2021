using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AtacadoAPI.Model;

namespace AtacadoAPI.Data.Dtos.Venda
{
    public class ReadVendaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Quantidade é obrigatória")]
        public Double Quantidade { get; set; }
        [Required(ErrorMessage = "Data é obrigatória")]
        public String Data { get; set; }
        public string Message { get; set; }
    }
}
