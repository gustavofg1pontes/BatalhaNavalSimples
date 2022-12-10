using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNavalSimples
{
    public class Tabuleiros
    {
        public Navio[,] tabuleiro1 = new Navio[8, 8];
        public Navio[,] tabuleiro2 = new Navio[8, 8];
        public int jogadorAtual = 1;

        public Tabuleiros() { }

        public void adicionaNavio(int posicao1, int posicao2)
        {
            getTabuleiroAtual()[posicao1, posicao2] = new Navio();
        }

        public Navio[,] getTabuleiroAtual()
        {
            if(jogadorAtual == 1) return tabuleiro1;
            return tabuleiro2;
        }

    }
}
