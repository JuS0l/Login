using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Colaborador
    {
        [Display(Name = "Id", Description = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome")]
        public string Nome { get; set; }

        [Display(Name = "Senha", Description = "Senha do Colaborador")]
        public string Senha { get; set; }

        [Display(Name = "E-mail", Description = "Email do Colaborador")]
        public string Email { get; set; }

        [Display(Name = "Tipo", Description = "Tipo do Colaborador")]
        public string Tipo { get; set; }
    }
}
