

using System;
using System.ComponentModel.Design;

namespace Calculadora
{


    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }



        public static void Menu()
        {

            Console.WriteLine("Bem vindos à calculadora Imã!");
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine();
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine();
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine();
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine();
            Console.WriteLine("Digite 5 para potenciação");

            Console.WriteLine();

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    Console.Clear();
                    Somar();
                    break;
                case 2:
                    Console.Clear();
                    Subtrair();
                    break;
                case 3:
                    Console.Clear();
                    Multiplicar();
                    break;

                case 4:
                    Console.Clear();
                    Dividir();
                    break;
                case 5:
                    Console.Clear();
                    Potenciar();
                    break;
          
            };

        }


        public static void Somar()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int soma = valor1 + valor2;
            Console.WriteLine($"O resultado é {soma}");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            Console.Clear();
            Sair();

        }

        public static void Subtrair()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int subtracao = valor1 - valor2;
            Console.WriteLine($"O resultado é {subtracao}");


            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            Console.Clear();
            Sair(); 

        }

        public static void Multiplicar()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int multiplicacao = valor1 * valor2;
            Console.WriteLine($"O resultado é {multiplicacao}");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            Console.Clear();
            Sair();
            

        }


        public static void Dividir()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Clear();

            int divisao = valor1 / valor2;
            Console.WriteLine($"O resultado é {divisao}");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            Console.Clear();
            Sair();

        }


        public static void Potenciar()
        {
            Console.Clear();
            Console.Write("Informe a base: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe o expoente: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Clear();

            double potenciar = Math.Pow(valor1, valor2);


            Console.WriteLine($"O resultado de {valor1} elevado a {valor2} é {potenciar}");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();

            Console.Clear();
            Sair();

        }


        public static void Sair()
        {
            
            Console.WriteLine("Obrigada por ter usado a nossa calculadora");
            Console.WriteLine();
            Console.WriteLine("Se você gostou, digite SIM. Se acha que precisamos melhorar, digite NÃO:");
            string opcao = Console.ReadLine();  

            if(opcao == "SIM")
            {
                Console.WriteLine();
                Console.WriteLine("Agradecemos a preferência");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Console.ReadKey();
                Console.Clear();
                Menu(); 

            }
            else
            {
                Console.WriteLine(); 
                Console.WriteLine("Vamos melhorar! Obrigada pelo feedback.");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Console.ReadKey();
                Console.Clear();
                Menu();

            }
        }














    }




















}


























//