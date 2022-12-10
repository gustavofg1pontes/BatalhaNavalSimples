namespace BatalhaNavalSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiroManager = new Tabuleiros();
            bool vencedor = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"\tJogador {tabuleiroManager.jogadorAtual}");
                DesenhaTabuleiro(tabuleiroManager);
                Console.WriteLine($"Jogador {tabuleiroManager.jogadorAtual} pronto? Clique qualquer botão para continuar");
                Console.ReadKey();
                int quantidadeNavios = 3;
                do
                {
                    Console.WriteLine("Primeiro decida a posição de seus navios! Digite número e letra (ex: 1A)");
                    string posicaoNavio = Console.ReadLine();

                } while (quantidadeNavios > 0);
                
            } while (!vencedor);
            
        }

        static void DesenhaTabuleiro(Tabuleiros tabuleiroManager)
        {
            int escreve = 1;
            Console.WriteLine("   A   B   C   D   E   F   G   H");
            foreach (Navio i in tabuleiroManager.getTabuleiroAtual())
            {
                if (i!=null) Console.Write($"   O");
                else Console.Write($"   x");
                if (escreve % 8 == 0)
                {
                    Console.CursorLeft = 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{escreve / 8}");
                    Console.WriteLine();
                }
                escreve++;
            }
        }


        public int posicaoLetra(string letra)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int index = alfabeto.IndexOf(letra.ToLower());
            return index;
        }
    }
}