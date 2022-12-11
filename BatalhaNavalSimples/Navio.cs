using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNavalSimples
{
    public class Navio
    {
        public Navio(int vida) {
            Vida = vida;
        }
        public Navio() { }

        public int Vida { get; set; }
    }
}
