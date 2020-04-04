using System;

namespace ExercicioAvanade2
{
    class Program
    {
        static void Main(string[] args)
        {
            double vale, salario, total;

            Console.WriteLine("Digite o valor do vale: ");
            try
            {
                vale = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro no sistema, informe o valor");
                return;
            }
            Console.WriteLine("Digite o valor do salário: ");
            try
            {
                salario = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro no sistema, informe o valor");
                return;
            }
            total = vale + salario;
            Console.WriteLine("O resultado da operação é: " + total);

            if (total <= 3000)
            {
                total = (total * 1.05);
                Console.WriteLine("O novo salário é: " + total);
                return;
            }
        }
    }
}
