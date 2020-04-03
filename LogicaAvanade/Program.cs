using System;

namespace LogicaAvanade
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Digite o primeiro número da operação");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro no sistema, você precisa digitar um número");
                return;
            }
            
            Console.WriteLine("Digite o segundo número da operação");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro no sistema, você precisa digitar um número");
                return;
            }
            int c = a + b;

            Console.WriteLine("O resultado da operação é:" + c);
            
            Console.ReadLine();
        }
    }
}
