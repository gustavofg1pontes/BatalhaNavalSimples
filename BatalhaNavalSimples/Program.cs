namespace BatalhaNavalSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiroManager = new Tabuleiros();
            bool decidindoNavios = true;
            Console.WriteLine("Desejam jogar com quantos navios?");
            int quantNavios = int.Parse(Console.ReadLine());
            do
            {
                DesenhaTabuleiro(tabuleiroManager);
                Console.ReadKey();
                int quantidadeNavios = quantNavios;
                do
                {
                    Console.WriteLine("Primeiro decida a posição de seus navios! Digite número e letra (ex: 1A)");
                    string posicaoNavio = Console.ReadLine();
                    tabuleiroManager.adicionaNavio(int.Parse(posicaoNavio.Substring(0, 1)) - 1, posicaoLetra(posicaoNavio.Substring(1, 1)));
                    DesenhaTabuleiro(tabuleiroManager);
                    quantidadeNavios--;
                } while (quantidadeNavios > 0);

                if (tabuleiroManager.jogadorAtual == 1) tabuleiroManager.jogadorAtual = 2;
                else decidindoNavios = false;
            } while (decidindoNavios);
            
        }

        static void DesenhaTabuleiro(Tabuleiros tabuleiroManager)
        {
            int escreve = 1;
            Console.Clear();
            Console.WriteLine($"\tJogador {tabuleiroManager.jogadorAtual}");
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
            Console.WriteLine($"Jogador {tabuleiroManager.jogadorAtual} pronto? Clique qualquer botão para continuar");
        }


        static int posicaoLetra(string letra)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int index = alfabeto.IndexOf(letra.ToLower());
            return index;
        }
    }
}