using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MykytiukOleksandra3F
{
    internal class Program
    {
        class Card
        {
            public string Suit;
            public string Number;
            public override string ToString() => $" {Number} {Suit}";
        }

            static void Main(string[] args)
        {
            string[] suit = { "pik", "kier", "karo", "trief" };
            string[] number = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "wallet", "dama", "król", "as" };
            List<Card> talia = new List<Card>();
            foreach(string s in suit)
            {
                foreach(string n in number)
                {
                    talia.Add(new Card
                    {
                        Suit = s,
                        Number = n
                    });
                }
            }
            Random random = new Random();
            for(int i=talia.Count-1; i>=0; i--)
            {
                int j=random.Next(talia.Count);
                var t=talia[i];
                talia[i]=talia[j];
                talia[j]=t;
            }
            List<Card> heand1=new List<Card>();
            List<Card> heand2=new List<Card>();
            for(int i=0; i<5; i++)
            {
                heand1.Add(talia[i]);
            }
            for(int i=5; i < 10; i++)
            {
                heand2.Add(talia[i]);
            }
            
            for (int i = 0; i < heand1.Count; i++)
            {
                for (int j = 0; j < heand1.Count - 1; j++)
                {
                    if (Array.IndexOf(number, heand1[j].Number) > Array.IndexOf(number, heand1[j + 1].Number))
                    {
                        (heand1[j], heand1[j + 1]) = (heand1[j + 1], heand1[j]);
                    }
                }
            }

            for (int i = 0; i < heand2.Count; i++)
            {
                for (int j = 0; j < heand2.Count - 1; j++)
                {
                    if (Array.IndexOf(number, heand2[j].Number) > Array.IndexOf(number, heand2[j + 1].Number))
                    {
                        (heand2[j], heand2[j + 1]) = (heand2[j + 1], heand2[j]);
                    }
                }
            }
            Console.WriteLine("\nRęka 1 po sortowaniu:");
            foreach (var k in heand1)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("\nRęka 2 po sortowaniu:");
            foreach (var k in heand2)
            {
                Console.WriteLine(k);
            }
            Card ser = new Card { Number = "as", Suit = "pik" };
            int index = -1;
            for (int i = 0; i<talia.Count; i++)
            {
                if(talia[i].Number==ser.Number && talia[i].Suit == ser.Suit){
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"\nas pik znajduje się na indeksie: {index}");


            Console.ReadKey();

        }

    }
}
