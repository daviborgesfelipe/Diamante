using System.Reflection;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Digite um número ímpar: ");
                int numeroInpar = int.Parse(Console.ReadLine());
                if (numeroInpar % 2 == 0)
                {
                    Console.WriteLine("O número digitado não é ímpar.");
                    Console.ReadLine();
                    continue;
                }

                int metade = numeroInpar / 2;
                for (int quandidadeDeLinha = 0; quandidadeDeLinha <= metade; quandidadeDeLinha++)//para cada linha
                {
                    for (int quantidadeCaracterNaLinha = 0; quantidadeCaracterNaLinha < numeroInpar; quantidadeCaracterNaLinha++)//para cada caractere na linha
                    {
                        if (Math.Abs(metade - quantidadeCaracterNaLinha) <= quandidadeDeLinha)
                        {
                            Console.Write('x');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }

                for (int quandidadeDeLinha = metade + 1; quandidadeDeLinha < numeroInpar; quandidadeDeLinha++)
                {
                    for (int quantidadeCaracterNaLinha = 0; quantidadeCaracterNaLinha < numeroInpar; quantidadeCaracterNaLinha++)
                    {
                        if (Math.Abs(metade - quantidadeCaracterNaLinha) <= numeroInpar - quandidadeDeLinha - 1)
                        {
                            Console.Write('x');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
