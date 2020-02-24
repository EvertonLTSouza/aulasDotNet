using System;

namespace Aulas_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 de Decisão
            /*
            var compara = new Maior();
            
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("O maior numero digitado foi: " + compara.MaiorNumero(num1, num2));

            Console.ReadKey();
            */

            //Exercicio 1 de Comparação
            /*
            var valida = new Repeticao1();

            Console.WriteLine("Digite um numero entre 0 e 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while(valida.Valida(num))
            {
                Console.WriteLine("Digite um numero entre 0 e 10: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
            */
            
            //Segundo exercicio de decisão
            /*
            var posNeg = new Decisao2();

            Console.WriteLine("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("O numero digitado é " + posNeg.posNeg(num));
            Console.ReadKey();
            */

            //Segundo exercicio de Repeticao
            var compStr = new Repeticao2();
            
            Console.Write("Digite o usuário: ");
            string usuario = Console.ReadLine();
            string senha;
            do
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
            }
            while(compStr.compStr(usuario, senha));
            Console.ReadKey();
            
        }

    }
}

