using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtacadoAPI.Model
{
    public class Venda
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Quantidade é obrigatória")]
        public Double Quantidade { get; set; }
        [Required]
        public String Data { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public virtual Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
