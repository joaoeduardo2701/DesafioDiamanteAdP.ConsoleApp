namespace Diamante.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite o tamanho do diamante: ");
        int tamanhoDoDiamante = int.Parse(Console.ReadLine());

        int quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;
        int quantidadeDeEspacos = (tamanhoDoDiamante - 1) / 2;
        int quantidadeDeX = 1;

        DesenharParteSuperior(quantidadeDeLinhas, ref quantidadeDeEspacos, ref quantidadeDeX);

        DesenharParteDoMeio(tamanhoDoDiamante);

        quantidadeDeEspacos = DesenharParteInferior(quantidadeDeLinhas, ref quantidadeDeX);
    }

    private static void DesenharParteDoMeio(int tamanhoDoDiamante)
    {
        for (int coluna = 0; coluna < tamanhoDoDiamante; coluna++)
        {
            Console.Write("x");
        }

        Console.WriteLine();
    }

    private static int DesenharParteInferior(int quantidadeDeLinhas, ref int quantidadeDeX)
    {
        int quantidadeDeEspacos = 1;
        quantidadeDeX -= 2;

        for (int linha = 0; linha < quantidadeDeLinhas; linha++)
        {
            for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                Console.Write(" ");

            for (int x = 0; x < quantidadeDeX; x++)
                Console.Write("x");

            quantidadeDeEspacos++;
            quantidadeDeX -= 2;

            Console.WriteLine();
        }

        return quantidadeDeEspacos;
    }

    private static void DesenharParteSuperior(int quantidadeDeLinhas, ref int quantidadeDeEspacos, ref int quantidadeDeX)
    {
        for (int linha = 0; linha < quantidadeDeLinhas; linha++)
        {
            for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                Console.Write(" ");

            for (int x = 0; x < quantidadeDeX; x++)
                Console.Write("x");

            quantidadeDeEspacos--;
            quantidadeDeX += 2;
            Console.WriteLine();
        }
    }
}
