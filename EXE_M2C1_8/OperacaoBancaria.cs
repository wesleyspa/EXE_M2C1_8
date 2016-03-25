using System;
using System.Collections.Generic;

namespace EXE_M2C1_8
{
    public class OperacaoBancaria
    {
        public void Saque(ContaCorrente cc)
        {
            Console.WriteLine("Valor para saque");
            decimal p_valor = decimal.Parse(Console.ReadLine());


            cc.saldo += -p_valor;
        }

        public void Deposito(ContaCorrente cc)
        {
            Console.WriteLine("Valor para depósito");
            decimal p_valor = decimal.Parse(Console.ReadLine());


            cc.saldo += +p_valor;
        }

        public Boolean Transferencia(List<ContaCorrente> cc, ContaCorrente OrigemCC)
        {
            Console.WriteLine("Digite a conta Destino");
            int ccDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para transferência");
            decimal valorTransferencia = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Deseja realmente transferir R$ {0} de {1} para {2} ?", valorTransferencia, OrigemCC.numConta, ccDestino);
            Boolean confirma = bool.Parse(Console.ReadLine());

            if (!confirma)
                return false;

            
            int indexDestino= cc.FindIndex(c => c.numConta.Equals(ccDestino));

            if (!(indexDestino > 0))
                return false;

            OrigemCC.saldo = OrigemCC.saldo - valorTransferencia;
            cc[indexDestino].saldo = cc[indexDestino].saldo + valorTransferencia);

            return true;
        }

        public ContaCorrente cadastrarCC()
        {

            Console.WriteLine("Digite o nome do titular da conta");
            string nomeTitular = Console.ReadLine();

            Random generateNumConta = new Random();
            
            int numConta = generateNumConta.Next(1000,9999);

            ContaCorrente cc = new ContaCorrente(new Cliente(nomeTitular), numConta);

            return cc;
        }

        public int Logar(List<ContaCorrente> cadastroCC)
        {
            Console.Write("Conta : ");
            int indexConta = int.Parse(Console.ReadLine());

            indexConta = cadastroCC.FindIndex(c => c.numConta.Equals(indexConta));

            return indexConta;
        }

        public void Saldo(ContaCorrente cc)
        {
            Console.WriteLine("Saldo da conta {0}", cc.saldo);
        }

    }
}
