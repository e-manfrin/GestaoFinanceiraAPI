using System;

namespace ContaAPI.Dtos
{
    public class ContaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public ContaResponse(string nome, string descricao, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public ContaResponse()
        { }
    }
}
