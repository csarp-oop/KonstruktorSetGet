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

        public override string ToString()
        {
            return "("+x+","+y+")";
        }
    }

    abstract class Jarmu
    {
        protected Pozicio pozicio;

        public Jarmu(int x, int y)
        {
            pozicio = new Pozicio(x, y);
        }

        public void menjFel()
        {
            pozicio.Y = pozicio.Y + 1;
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

        public override string ToString()
        {
            return 
                rendszam+" autó"+
                " amelyik "+szin+" színű "+
                pozicio+" pozicióban van";
        }
    }

    class Kerekpar : Jarmu
    {
        private string szin;

        public Kerekpar(int x, int y, string rendszam, string szin)
            : base(x, y)
        {
            this.szin = szin;
        }

        public override string ToString()
        {
            return
                " Bicikli amelyik " +
                szin + " színű " +
                pozicio + " pozicióban van";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto(0, 0, "AAA-001", "rózsaszín");
            a.menjFel();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
