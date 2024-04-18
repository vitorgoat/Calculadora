using System;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando as funções dentro do método Main
            // Soma();
            // Substracao();
            // Divisao();
            // Multiplicacao();

            // Ao invés de chamar as funções podemos chamar apenas o menu
            Menu();

        }
        // função menu
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Divisão");
            Console.WriteLine(" 4 - Multiplicação");
            Console.WriteLine(" 5 - Sair");

            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção: ");
            // valores simples de 1 a 5 podemos usar o short
            short res = short.Parse(Console.ReadLine());

            // Switch case irá realizar a verificação dos valores para então
            // determinar uma ação
            // default vai entrar quando o usuario chamar qqr numero que nao esteja no case
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Substracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                // System.Environment.Exit -> Para sair do sistema e o (0) sigfnica que saiu com sucesso.
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        //Método Soma, criada fora do método 'Main'
        static void Soma()
        {
            // Limpar o console
            Console.Clear();
            // Mostramos na tela pro usuario inserir um valor
            Console.WriteLine("Primeiro valor: ");
            // Recebemos um valor na tela do usuario e armazenamos em uma variavel
            // Console.readline le a linha e espera o user apertar enter
            // o console retorna uma string, então temos que converter com float.parse
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            // exemplo de interpolação de strings com '$'
            Console.WriteLine($"O resultado da soma é {resultado}");
            // ReadKey é Para não parar a execução
            Console.ReadKey();
            // Depois do enter ele retornará para o menu
            // abaixo é um exemplo que podemos chamar uma função dentro de uma função.
            Menu();



        }

        //Método Subtracao.
        static void Substracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado a subtração é {resultado}");
            // ReadKey é Para não parar a execução
            Console.ReadKey();
            Menu();
        }

        //Método divisão.
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();


        }
    }

}