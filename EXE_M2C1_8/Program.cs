using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_8
{
    class Program
    {

        public static List<ContaCorrente> InserirCliente()
        {
            int i = 0;

            List<ContaCorrente> cc = new List<ContaCorrente>();

            do
            {
                Console.WriteLine("Digite o nome");
                string p_nome = Console.ReadLine();

                Console.WriteLine("Digite o número da conta");
                int p_numConta = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o saldo da conta");
                decimal p_saldo = decimal.Parse(Console.ReadLine());

                cc.Add(new ContaCorrente(new Cliente(p_nome, 0), p_numConta));
                cc[i].saldo = p_saldo;

                i++;
            } while (i <= 3);

            return cc;
        }


        static void Main(string[] args)
        {
            List<ContaCorrente> cc = new List<ContaCorrente>();

            cc = InserirCliente();
            cc.Sort();

            Console.WriteLine("Qtd. operações realizadas");
            int qtdOperacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdOperacoes; i++)
            {
                Console.WriteLine("Número da Conta");
                int numConta = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo de Operação");
                string tpOperacao = Console.ReadLine();

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


        }
    }
}
