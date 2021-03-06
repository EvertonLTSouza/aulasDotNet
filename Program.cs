﻿using System;

namespace Aulas_dotNet
{
    class Program
    {   
        static void Main(string[] args)
        {   
            //Repeticao 7


            //Decisao 7
            /*
            var numero = new Decisao6();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Digite o "+ (i+1) + "° numero: ");
                numero.setNumero(
                    Convert.ToInt32(Console.ReadLine()),
                    i
                );
            }

            Console.WriteLine("O Maior numero digitado foi: " + numero.maiorNumero());
            Console.Write("O Menor numero digitado foi: " + numero.menorNumero());


            Console.ReadKey();
            */
            //Repetição 6
            /*
            var impr = new Repeticao6();

            for (int i = 0; i < 20; i++){
                impr.printNextLine();
            }
            impr.setNum(1);
            for (int i = 0; i < 20; i++){
                impr.printNextNum();
            }
            Console.ReadKey();
            */
            /*
            //Exercicio 6 de Decisao
            var numero = new Decisao6();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Digite o "+ (i+1) + "° numero: ");
                numero.setNumero(
                    Convert.ToInt32(Console.ReadLine()),
                    i
                );
            }

            Console.Write("O Maior numero digitado foi: " + numero.maiorNumero());

            Console.ReadKey();
            */

            //Exercicio 5 de Repeticao
            /*
            var populacao = new Repeticao4();
            Console.Write("Entre com a População A: ");
            populacao.populacaoA = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Entre com a População B (Deve ser maior que a A): ");
                populacao.populacaoB = Convert.ToInt32(Console.ReadLine());    
            }
            while(populacao.Maior());
        
            Console.Write("Entre com a Taxa de Crescimento B: ");
            populacao.setTaxaB(Convert.ToDouble(Console.ReadLine()));
            do
            {
                Console.Write("Entre com a Taxa de Crescimento A (Deve ser Maior que a taxa B): ");
                populacao.setTaxaA(Convert.ToDouble(Console.ReadLine()));
            }
            while(!populacao.CompTaxa());

            while(!populacao.Maior())
            {
                Console.WriteLine(
                    "Ano:   " + populacao.ano + 
                    "     Populacao A: " + populacao.populacaoA + 
                    "     Populacao B: " + populacao.populacaoB);
                populacao.proxAno();
            }
            Console.ReadKey();
            */
            //Exercicio 5 de decisão
            /*
            var aluno = new Decisao5();
            Console.Write("Digite a primeira nota: ");
            aluno.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a primeira nota: ");
            aluno.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Situação: " + aluno.Situacao());
            Console.ReadKey();
            */
            /*
            //Exercicio 4 de Repetição
            var populacao = new Repeticao4();
            while(!populacao.Maior())
            {
                Console.WriteLine(
                    "Ano:   " + populacao.ano + 
                    "     Populacao A: " + populacao.populacaoA + 
                    "     Populacao B: " + populacao.populacaoB);
                populacao.proxAno();
            }
            

            Console.ReadKey();
            */

            //Exercicio 4 de decisao
            /*
            var vogal = new Decisao4();

            Console.Write("Digite um caracter: ");
            var vog = System.Convert.ToChar(Console.ReadLine());

            if (vogal.volga(vog))
            {
                Console.WriteLine("Voce digitou uma Vogal");
            }
            else
            {
                Console.WriteLine("Voce digitou uma Consoante");
            }

            Console.ReadKey();

            */

            //Exercicio 3 de Repeticao
            /*
            var validacoes = new Repeticao3();
            
            string nome;
            int idade, salario;
            char sexo, estadoCivil;
            
            do
            {
            Console.Write("Digite nome com mais de 3 caracteres: ");
            nome = Console.ReadLine();
            }
            while(!validacoes.ValidaNome(nome));

            do
            {
            Console.Write("Digite idade entre 0 e 150: ");
            idade = System.Convert.ToInt32(Console.ReadLine());
            }
            while(!validacoes.ValidaIdade(idade));

            do
            {
            Console.Write("Digite salario acima de 0: ");
            salario = System.Convert.ToInt32(Console.ReadLine());
            }
            while(!validacoes.ValidaSalario(salario));

            do
            {
            Console.Write("Digite sexo (M/F): ");
            sexo = System.Convert.ToChar(Console.ReadLine());
            }
            while(!validacoes.ValidaSexo(sexo));

            do
            {
            Console.Write("Digite estado civil (s, c, v, d): ");
            estadoCivil = System.Convert.ToChar(Console.ReadLine());
            }
            while(!validacoes.ValidaEstadoCivil(estadoCivil));
            Console.Write(  
                "Nome: " + nome + 
                "\nIdade: " + idade + 
                "\nSalario: " + salario +
                "\nSexo: " + char.ToUpper(sexo) +
                "\nEstado Civil: " + char.ToUpper(estadoCivil));

            Console.ReadKey();
            */

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
            /*
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
            */

            //Exercicio 3 de Decisao
            /*
            var sexo = new Decisao3();

            Console.Write("Informe seu sexo (F/M): ");
            char genero = System.Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Sexo informado: " + sexo.Sexo(genero));
            Console.ReadKey();
            */
        }

    }
}

