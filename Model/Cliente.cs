using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtacadoAPI.Model
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Razão Social é obrigatória")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "CEP é obrigatório")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Número é obrigatório")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Data Atualização é obrigatório")]
        public string DataAtualizacao { get; set; }
        [Required(ErrorMessage = "Contato é obrigatório")]
        public string Contato { get; set; }
        [Required(ErrorMessage = "Status é obrigatório")]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }
        [JsonIgnore]
        public virtual Venda Venda { get; set; }

    }
}
