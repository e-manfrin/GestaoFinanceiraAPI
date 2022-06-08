using GestaoFinanceiraAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoFinanceiraAPI.Data
{
    public static class ContaContext
    {
        public static List<Conta> lista = new List<Conta>();
        

        private static void PopularContas()
        {
            lista.Add(new Conta(1,"telefone", "pago", 100));
            lista.Add(new Conta(11, "telefone", "pago", 100));
            lista.Add(new Conta(12, "telefone", "pago", 100));
            lista.Add(new Conta(13, "telefone", "pago", 100));
            lista.Add(new Conta(14, "telefone", "pago", 100));
            lista.Add(new Conta(15, "telefone", "pago", 100));
            lista.Add(new Conta(16, "telefone", "pago", 100));
            lista.Add(new Conta(17, "telefone", "pago", 100));
            lista.Add(new Conta(18, "telefone", "pago", 100));
        }

        public static Conta ConsultarConta(int id)
        {
            PopularContas();
            Conta conta = lista.FirstOrDefault(contaLista => contaLista.Id == id);
            return conta;
        }
    }
}
