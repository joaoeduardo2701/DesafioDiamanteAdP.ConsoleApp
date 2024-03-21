namespace Diamante.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do diamante: ");
        int tamanho = int.Parse(Console.ReadLine());

        while (tamanho % 2 == 0)
        {
            Console.WriteLine("Por favor insira um número válido!");
            Console.WriteLine("Digite o tamanho do diamante: ");
            tamanho = int.Parse(Console.ReadLine());
        }

        int espacos = tamanho / 2;
        int qtdX = 1;

        for (int i = 0; i < tamanho / 2; i++)
        {

            for (int j = 0; j < espacos; j++)
            {
                Console.Write(" ");
                
            }

            for (int k = 0; k < qtdX; k++)
            {
                Console.Write("x");
            }

            espacos--;
            qtdX += 2;

            Console.WriteLine();
        }
        
        for (int i = 0; i < tamanho / 2 + 1; i++)
        {
            for (int j = 0;j < espacos; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < qtdX; k++)
            {
                Console.Write("x");
            }

            espacos++;
            qtdX -= 2;

            Console.WriteLine();
        }
    }
}
