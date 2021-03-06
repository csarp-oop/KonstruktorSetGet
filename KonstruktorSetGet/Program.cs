﻿using System;
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

        /// <summary>
        /// Dog osztály nevet kérő konstruktora
        /// </summary>
        /// <param name="name">A kutya neve</param>
        public Dog(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Set metódus a kutya életkorának megadására
        /// </summary>
        /// <param name="age">A kutya életkora</param>
        public void setAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// A kutya adatainak megjelenítése stringként
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name+" kutya "+ age+" éves.";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Egy Dog objekutm példányosítása
            Dog r = new Dog("Rex");
            //Set metódussal kutya életkorának megadása
            r.setAge(2);
            //Kutya adatainak kiírása a képernyőre
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
