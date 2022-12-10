using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNavalSimples
{
    public class Navio
    {
        public Navio(int x, int y, int length) {
            X = x;
            Y = y;
            Length = length;
        }
        public Navio() { }


        public int X { get; set; }
        public int Y { get; set; }
        public int Length { get; set; }
    }
}
