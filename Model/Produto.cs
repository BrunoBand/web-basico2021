using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace AtacadoAPI.Model
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do Produto é obrigatório mínimo 3, máximo 30 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Valor do Produto é obrigatório")]
        public double Valor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        [Required(ErrorMessage = "Campo Fornecedor ID é obrigatório!")]
        public int FornecedorId { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "Quantidade do Produto é obrigatório")]
        public double Quantidade { get; set; }
        [JsonIgnore]
        public virtual Venda Venda { get; set; }

    }

}
