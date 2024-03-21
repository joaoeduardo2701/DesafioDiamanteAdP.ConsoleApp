namespace Diamante.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do diamante: ");
        int tamanho = int.Parse(Console.ReadLine());

        for (int i = 0; i < tamanho; i++)
        {
            //parte de cima

            for (int j = 0; j < tamanho / 2; j++)
            {
                Console.Write("b");

            }

            //parte do meio

            Console.Write("x");

            //parte de baixo
        }
    }
}
