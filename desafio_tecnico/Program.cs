using System;

class Program
{
    static void Main()
    {
        string jogador1 = "Gustavo"; 
        string nome1 = "Lionel Messi";
        int forca1 = 10;
        int agilidade1 = 14;
        int inteligencia1 = 12;
        int vida1 = 100;

        string jogador2 = "Erick";
        string nome2 = "Neymar Jr";
        int forca2 = 20;
        int agilidade2 = 12;
        int inteligencia2 = 20;
        int vida2 = 90;

        Console.WriteLine("--- SIMULADOR DE BATALHA RPG ---");

        for (int i = 1; i <= 2; i++)
        {
            int nomeAtual = i;

            if (i == 1)
            {
                Console.WriteLine($"\nJogador: {jogador1}");
                Console.WriteLine($"\nPersonagem: {nome1}");
            }
            else
            {
                Console.WriteLine($"\nJogador: {jogador2}");
                Console.WriteLine($"\nPersonagem: {nome2}");
            }
        }

        Console.WriteLine("\nRegra Escolhida: Regra 1 - Ofensiva (Força + Agilidade)");
        Console.WriteLine("-------------------------------------------------------");

        int poder1 = CalcularPoder(forca1, agilidade1);
        int poder2 = CalcularPoder(forca2, agilidade2);

        if (poder1 > poder2)
        {
            Console.WriteLine($"O VENCEDOR É: {nome1}!");
            Console.WriteLine($"Pontos de Ataque: {poder1} vs {poder2}");
        }
        else if (poder2 > poder1)
        {
            Console.WriteLine($"O VENCEDOR É: {nome2}!");
            Console.WriteLine($"Pontos de Ataque: {poder2} vs {poder1}");
        }
        else
        {
            Console.WriteLine("A batalha terminou em um empate épico!");
        }
    }
    static int CalcularPoder(int f, int a)
    {
        return f + a;
    }
}