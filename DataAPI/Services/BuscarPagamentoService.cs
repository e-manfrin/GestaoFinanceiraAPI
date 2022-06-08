using ContaAPI.Dtos;
using GestaoFinanceiraAPI.Data;
using GestaoFinanceiraAPI.Models;

namespace GestaoFinanceiraAPI.Services
{
    public class BuscarPagamentoService
    {
        public ContaResponse BuscarPagamento(int id)
        {
            Conta conta = ContaContext.ConsultarConta(id);
            if (conta == null)
            {
                return null;
            }
            ContaResponse contaResponse = ConverterContaEmContaResponse(conta);

            return contaResponse;
        }

        private ContaResponse ConverterContaEmContaResponse(Conta conta)
        {
            ContaResponse contaResponse = new ContaResponse();

            contaResponse.Id = conta.Id;
            contaResponse.Nome = conta.Nome;
            contaResponse.Descricao = conta.Descricao;
            contaResponse.Valor = conta.Valor;

            return contaResponse;
        }
    }
}
