using System.ComponentModel.DataAnnotations;

namespace PrimeiroApp.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int? IdUsu {  get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage ="Ocampo nome é obrigatório")]
        public string NomeUsu { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O campo cargo é obrigatório")]
        public string Cargo { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "O campo nasccimento é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime DataNasc { get; set; }
    }
}
