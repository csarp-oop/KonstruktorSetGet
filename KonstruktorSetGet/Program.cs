using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorSetGet
{
    /// <summary>
    /// Dog osztály
    /// </summary>
    class Dog
    {
        /// <summary>
        /// Az osztály tulajdonságai (properties)
        /// A kutya neve
        /// </summary>
        private string name;
        /// <summary>
        /// A kutya életkora
        /// </summary>
        private int age;

        ///Konstruktor
        /// Konstruktor neve megegyezik az osztály nevével
        /// Konstruktornak nincs visszatérési értéke
        /// Konstroktor kívülről elérhető kell legyen
        public Dog(string name)
        {
            this.name = name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
