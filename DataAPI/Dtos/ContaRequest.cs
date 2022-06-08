using System;
using System.ComponentModel.DataAnnotations;

namespace ContaAPI.Dtos
{
    public class ContaRequest
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório")]
        public double Valor { get; set; }
    }
}
