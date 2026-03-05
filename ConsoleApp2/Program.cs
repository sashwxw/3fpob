using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Uczen
    {
        public string Imie { get; set; }
        public double Srednia { get; set; }

        public Uczen(string imie, double srednia)
        {
            Imie = imie;
            Srednia = srednia;
        }
    }
    internal class Program
    {
        static int WyszLiniowe(Uczen[] tablica, string szukana)
        {
            for(int i=1;  i<=tablica.Length; i++)
            {
                if (tablica[i-1].Imie == szukana)
                {
                    return i; 
                }
            }
            return -1;
        }
        static double MaxSr(Uczen[] tablica)
        {
            double max = tablica[0].Srednia;

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i].Srednia > max)
                {
                    max = tablica[i].Srednia;
                }
            }

            return max;
        }
        static double Sr(Uczen[] tablica)
        {
            int sum = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                sum+=
            }
        }
        static double MinSr(Uczen[] tablica)
        {
            double min = tablica[0].Srednia;

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i].Srednia < min)
                {
                    min = tablica[i].Srednia;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            Uczen[] uczniowie = new Uczen[5];
            uczniowie[0] = new Uczen("Anna", 4.5);
            uczniowie[1] = new Uczen("Piotr", 3.8);
            uczniowie[2] = new Uczen("Jan", 5.0);
            uczniowie[3] = new Uczen("Maria", 4.2);
            uczniowie[4] = new Uczen("Krzysztof", 3.5);
            foreach (var uczen in uczniowie)
            {
                Console.WriteLine(uczen.Imie+": "+ uczen.Srednia+";");
            }
            int im = WyszLiniowe(uczniowie, "Anna");
            Console.WriteLine("Indeks: "+im);
            double m = MaxSr(uczniowie);
            double mi=MinSr(uczniowie);
            foreach (var uczen in uczniowie)
            {
                if (uczen.Srednia == m)
                {
                    Console.WriteLine("Uczeń z największą średnią:" + uczen.Imie + "(" + uczen.Srednia + ");");
                }
                if (uczen.Srednia == mi)
                {
                    Console.WriteLine("Uczeń z najniższą średnią:" + uczen.Imie + "(" + uczen.Srednia + ");");
                }
            }
            

        }
        
    }
}
