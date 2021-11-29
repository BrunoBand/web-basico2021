using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtacadoAPI.Data.Dtos.Compra
{
    public class ReadCompraDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Quantidade é obrigatório!")]
        public Double Quantidade { get; set; }
        [Required(ErrorMessage = "Campo Data é obrigatório!")]
        public String Data { get; set; }
        public string Message { get; set; }
    }
}
