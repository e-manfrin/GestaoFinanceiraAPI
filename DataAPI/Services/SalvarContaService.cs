using ContaAPI.Dtos;
using GestaoFinanceiraAPI.Models;
using System;

namespace GestaoFinanceiraAPI.Services
{
    public class SalvarContaService
    {
        public void SalvarConta(ContaRequest contaRequest)
        {
            Conta conta = ConverterContaRequestEmConta(contaRequest);
            Random random = new Random();
            conta.Id = random.Next(1);
        }

        private Conta ConverterContaRequestEmConta(ContaRequest contaRequest)
        {
            Conta conta = new Conta();

            conta.Nome = contaRequest.Nome;
            conta.Descricao = contaRequest.Descricao;
            conta.Valor = contaRequest.Valor;

            return conta;
        }
    }
}
