using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtacadoAPI.Model
{
    public class Fornecedor
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Razão Social é obrigatório!")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Campo CNPJ é obrigatório!")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Campo CEP é obrigatório!")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Campo Número é obrigatório!")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Campo Data de Atualização é obrigatório!")]
        public string DataAtualizacao { get; set; }
        [Required(ErrorMessage = "Campo Contato é obrigatório!")]
        public string Contato { get; set; }
        [Required(ErrorMessage = "Campo Status é obrigatório!")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Telefone é obrigatório!")]
        public string Telefone { get; set; }
        [JsonIgnore]
        public virtual Produto Produto { get; set; }

    }
}
