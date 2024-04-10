using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_uppgift_2_och_3
{
    internal class personuppgifter
    {
        public string förnamn;
        public string efternamn;
        public int ålder;

        public void MataIn()
        {
            Console.WriteLine("Vad heter du i förnamn?");
            förnamn = Console.ReadLine();
            Console.WriteLine("Vad heter du i efternamn?");
            efternamn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hej {förnamn} {efternamn}!");
            Console.WriteLine("Hur gammal är du?");
            ålder = int.Parse(Console.ReadLine());

            if (Myndig() == true)
            {
                Console.WriteLine("Du är myndig!!!");
            }
            else
            {
                Console.WriteLine("Du är inte mydnig :(");
            }
        }

        public bool Myndig()
        {
            if (ålder >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
