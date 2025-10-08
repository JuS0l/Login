using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Cliente
    {
        [Display(Name = "Id", Description = "Código")]
        public int Id {get; set; }
        
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome")]
        public string Nome { get; set; }
        
        [Display(Name = "Data de Nascimento", Description = "Dia, Mês e Ano")]
        public DateOnly DataNascimento { get; set; }
        
        [Display(Name = "Gênero", Description = "F ou M"), MaxLength(1)]
        public string Sexo { get; set; }
        
        [Display(Name = "Documento", Description = "Documento do Cliente")]
        public int CPF { get; set; }
        
        [Display(Name = "Telefone", Description = "Telefone do Cliente")]
        public int Telefone { get; set; }
        
        [Display(Name = "E-mail", Description = "Email do Cliente")]
        public string Email { get; set; }
        
        [Display(Name = "Senha", Description = "Senha do Cliente")]
        public string Senha { get; set; }
        
        [Display(Name = "Situação", Description = "Ativo ou Inativo")]
        public Boolean Situacao { get; set; }

    }
}
