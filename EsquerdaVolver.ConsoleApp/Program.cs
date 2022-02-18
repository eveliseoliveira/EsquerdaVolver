using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sentido;
            int vezes = 0;

            Console.WriteLine("Informe o número de comandos:");
            vezes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comando do soldado:");
            string comando = Console.ReadLine();

            char[] instrucoes = comando.ToCharArray();

            for(int i = 0; i <  vezes; i++)
            {
                if (instrucoes[i] == 'E')
                {
                    if (vezes == 1)
                        Console.WriteLine("O");
                    else if (vezes == 2)
                        Console.WriteLine("L");
                    else if (vezes == 3)
                        Console.WriteLine("S");
                    else if (vezes == 4)
                        Console.WriteLine("N");
                }
                if (instrucoes[i] == 'D')
                {
                    if (vezes == 1)
                        Console.WriteLine("L");
                    else if (vezes == 2)
                        Console.WriteLine("S");
                    else if (vezes == 3)
                        Console.WriteLine("O");
                    else if (vezes == 4)
                        Console.WriteLine("N");
                }
            }

        }
    }
}
