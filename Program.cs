using System;

namespace Aulas_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var compara = new Maior();
            
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("O maior numero digitado foi: " + compara.MaiorNumero(num1, num2));

            Console.ReadKey();
        }
    }
}

