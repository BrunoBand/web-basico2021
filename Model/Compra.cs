using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtacadoAPI.Model
{
    public class Compra
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Quantidade é obrigatório!")]
        public Double Quantidade { get; set; }
        [Required(ErrorMessage = "Campo Data é obrigatório!")]
        public String Data { get; set; }
        public virtual Produto Produto { get; set; }
        [Required(ErrorMessage = "Campo Produto ID é obrigatório!")]
        public int ProdutoId { get; set; }
    }
}
