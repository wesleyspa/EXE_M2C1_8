using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_8
{
    class Program
    {

        static void Main(string[] args)
        {
            OperacaoBancaria operacao = new OperacaoBancaria();

            string login = "1 - Fazer login   " +
                           "2 - Cadastrar Contas";

            string menuRaiz = "1 - Transferência   " +
                              "2 - Depósito   " +
                              "3 - Saque   " +
                              "4 - Saldo   " +
                              "5 - Outros   " +
                              "9 - Sair";

            string menuOutros = "1 - Cadastrar Cliente   " +
                                "2 - Operações em lote   " +
                                "9 - Voltar";

            List<ContaCorrente> cadastroCC = new List<ContaCorrente>();
            int Conta = 0;
            int nOpcao = 0;

            do
            {

                Console.WriteLine(login);
                nOpcao = int.Parse(Console.ReadLine());
                switch (nOpcao)
                {
                    case 1:
                        Conta = operacao.Logar(cadastroCC);
                        break;
                    case 2:
                        cadastroCC.Add(operacao.cadastrarCC());
                        break;
                }
            } while (nOpcao != 1);

            ContaCorrente ccCliente = new ContaCorrente(cadastroCC[Conta]);

            do
            {
                Console.WriteLine(menuRaiz);
                nOpcao = int.Parse(Console.ReadLine());

                switch (nOpcao)
                {
                    case 1:
                        operacao.Transferencia(cadastroCC, ccCliente);
                        break;
                    case 2:
                        operacao.Deposito(ccCliente);
                        break;
                    case 3:
                        operacao.Saque(ccCliente);
                        break;
                    case 4:
                        operacao.Saldo(ccCliente);
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine(menuOutros);
                            nOpcao = int.Parse(Console.ReadLine());

                        } while (nOpcao != 9);
                        break;





                    default
                        nOpcao = 9;
                }


            } while (nOpcao != 9);





                Console.WriteLine("Qtd. operações realizadas");
            int qtdOperacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdOperacoes; i++)
            {


                Console.WriteLine("Valor");
                decimal valor = decimal.Parse(Console.ReadLine());

                int index = cc.FindIndex(c => c.numConta.Equals(numConta));

                decimal p_saldo = cc[index].saldo;

                if (tpOperacao.Equals("C"))
                {
                    p_saldo = p_saldo + valor;
                }
                else
                {
                    p_saldo = p_saldo - valor;

                }

                cc[index].saldo = p_saldo;
            }

            foreach (var conta in cc)
            {
                Console.WriteLine("Titular : {0}", conta.dono.nome);
                Console.WriteLine("Conta : {0}", conta.numConta);
                Console.WriteLine("Saldo : {0}", conta.saldo);
            }



        }
    }
}
