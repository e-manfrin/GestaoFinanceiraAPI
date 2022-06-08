using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceiraAPI.Models
{
    public class Conta
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório")]
        public double Valor { get; set; }

        public Conta(int id,string nome, string descricao, double valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public Conta ()
        { }
    }
}
