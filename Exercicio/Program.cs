using Microsoft.VisualBasic;
using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, vale;

            Console.WriteLine("Digite o valor do seu salário");
            try
            {
                salario = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception err)
            {
                //throw err;
                Console.WriteLine("Erro no sistema, digite um número");
                return;
            }
            Console.WriteLine("Digite o valor do seu vale");
            try
            {
                vale = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro no sistema, digite um número");
                return;
            }

            double total = salario + vale;

            Console.WriteLine("O valor total é " + total);
        }

        
    }
}
