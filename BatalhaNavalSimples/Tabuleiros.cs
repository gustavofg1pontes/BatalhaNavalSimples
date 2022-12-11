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
        public bool vencedor = false;
        public Tabuleiros() { }

        public void adicionaNavio(int posicao1, int posicao2)
        {
            getTabuleiroAtual()[posicao1, posicao2] = new Navio(10);
        }

        public void atacarNavio(int posicao1, int posicao2)
        {
            trocarJogador();
            if (getTabuleiroAtual()[posicao1, posicao2] != null)
            {
                getTabuleiroAtual()[posicao1, posicao2].Vida -= 5;
                if (getTabuleiroAtual()[posicao1, posicao2].Vida <= 0) getTabuleiroAtual()[posicao1, posicao2] = null;
            }
        }

        public void verificaVencedor()
        {
            int contaBuracos = 0;
            foreach(Navio tabuleiro in getTabuleiroAtual())
            {
                if (tabuleiro == null) contaBuracos++;
            }
            if (contaBuracos == getTabuleiroAtual().Length)
            {
                trocarJogador();
                vencedor = true;
            }
        }

        public void trocarJogador()
        {
            if (jogadorAtual == 1) jogadorAtual = 2;
            else jogadorAtual = 1;
        }

        public Navio[,] getTabuleiroAtual()
        {
            if(jogadorAtual == 1) return tabuleiro1;
            return tabuleiro2;
        }
    }
}
