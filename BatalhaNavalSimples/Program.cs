namespace BatalhaNavalSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiroManager = new Tabuleiros();
            bool decidindoNavios = true;
            Console.WriteLine("\t\tBatalha Naval");
            Console.WriteLine("Desejam jogar com quantos navios?");
            int quantNavios = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine($"\tJogador {tabuleiroManager.jogadorAtual}");
                Console.WriteLine($"Jogador {tabuleiroManager.jogadorAtual} pronto? Clique qualquer botão para continuar");
                Console.ReadKey();
                DesenhaTabuleiro(tabuleiroManager);
                int quantidadeNavios = quantNavios;
                do
                {
                    Console.WriteLine("Primeiro decida a posição de seus navios! Digite número e letra (ex: 1A)");
                    string posicaoNavio = Console.ReadLine();
                    tabuleiroManager.adicionaNavio(int.Parse(posicaoNavio.Substring(0, 1)) - 1, posicaoLetra(posicaoNavio.Substring(1, 1)));
                    DesenhaTabuleiro(tabuleiroManager);
                    quantidadeNavios--;
                } while (quantidadeNavios > 0);

                if (tabuleiroManager.jogadorAtual == 1) tabuleiroManager.trocarJogador();
                else decidindoNavios = false;
            } while (decidindoNavios);

            tabuleiroManager.jogadorAtual = 1;
            do
            {
                Console.Clear();
                Console.WriteLine($"Vez do jogador {tabuleiroManager.jogadorAtual}. Preparado?");
                Console.ReadKey();
                DesenhaTabuleiro(tabuleiroManager);
                Console.WriteLine("Deseja atacar em qual posição? (ex: 1a)");
                string posicaoNavio = Console.ReadLine();
                tabuleiroManager.atacarNavio(int.Parse(posicaoNavio.Substring(0, 1)) - 1, posicaoLetra(posicaoNavio.Substring(1, 1)));
                Console.WriteLine("ATACANDO!!!");
                Console.ReadKey();
                tabuleiroManager.verificaVencedor();
            } while (!tabuleiroManager.vencedor);

            Console.WriteLine($"Parabéns, jogador {tabuleiroManager.jogadorAtual}!!!! Você venceu!");
        }

        static void DesenhaTabuleiro(Tabuleiros tabuleiroManager)
        {
            int escreve = 1;
            int left = 3;
            Console.Clear();
            Console.WriteLine($"Jogador {tabuleiroManager.jogadorAtual}:");
            Console.WriteLine("   A   B   C   D   E   F   G   H");
            foreach (Navio i in tabuleiroManager.getTabuleiroAtual())
            {
                Console.CursorLeft = left;
                if (i!=null) Console.Write($"{i.Vida}");
                else Console.Write($"x");
                left += 4;
                if (escreve % 8 == 0)
                {
                    Console.CursorLeft = 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{escreve / 8}");
                    Console.WriteLine();
                    left = 3;
                }
                escreve++;
            }
        }


        static int posicaoLetra(string letra)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int index = alfabeto.IndexOf(letra.ToLower());
            return index;
        }
    }
}