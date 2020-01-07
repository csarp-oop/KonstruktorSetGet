using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Pozicio {
        private int x;
        private int y;

        public Pozicio(int x, int y)
        {
            this.X = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }

    abstract class Jarmu
    {
        protected Pozicio pozicio;

        public Jarmu(int x, int y)
        {
            pozicio = new Pozicio(x, y);
        }
    }

    class Auto : Jarmu
    {
        private string rendszam;
        private string szin;

        public Auto(int x, int y,string rendszam, string szin)
            :base(x,y)
        {
            this.rendszam = rendszam;
            this.szin = szin;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
