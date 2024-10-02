using System;

namespace equacao2grau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o Valor de A da equação:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Valor de B da equação:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Valor de C da equação:");
            int c = int.Parse(Console.ReadLine());

            int delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais.");
                return; // se delta< 0 deu tao metendo o fake
            }

            double raiz = Math.Sqrt(delta); // Calcula a raiz quadrada
            double raiz1 = (-b + raiz) / (2 * a);
            double raiz2 = (-b - raiz) / (2 * a);

            Console.WriteLine("Esse é o delta: " + delta);
            Console.WriteLine("Essa é a raiz quadrada de delta: " + raiz);
            Console.WriteLine("Esse é o cálculo da primeira raiz: " + raiz1);
            Console.WriteLine("Esse é o cálculo da segunda raiz: " + raiz2);
            Console.WriteLine("Digite o que deseja fazer com as raízes. Tecle cada número respectivo:");
            Console.WriteLine("1 - Somar/ Adição");
            Console.WriteLine("2 - Produto/ Multiplicação");
            Console.WriteLine("3 - Subtração das raízes");

            int decisao = int.Parse(Console.ReadLine());

            while (decisao > 3 || decisao < 1)
            {
                Console.WriteLine("Valor inserido incorreto, insira um número dessas opções:");
                Console.WriteLine("1 - Somar/ Adição");
                Console.WriteLine("2 - Produto/ Multiplicação");
                Console.WriteLine("3 - Subtração das raízes");
                Console.WriteLine("Insira novamente o valor:");
                decisao = int.Parse(Console.ReadLine());
            }

            if (decisao == 1)
            {
                Console.WriteLine("A soma das raízes é: " + (raiz1 + raiz2));
            }
            else if (decisao == 2)
            {
                Console.WriteLine("O produto das raízes é: " + (raiz2 * raiz1));
            }
            else
            {
                Console.WriteLine("A subtração das raízes é: " + (raiz1 - raiz2));
                Console.WriteLine("Ou no outro caso: " + (raiz2 - raiz1));
            }

            Console.ReadLine();
        }
    }
}
