using System;

namespace Aulas_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Magica soma = new Magica();
            Console.WriteLine("Digite o primeiro numero da soma: ");
            int num1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Digite o primeiro numero da soma: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = soma.Soma(num1,num2);
            
            Console.WriteLine("A soma e igual a: " + result);

            Console.ReadKey();
        }
    }
}

