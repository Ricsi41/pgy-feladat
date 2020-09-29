using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-es feladat: ");
            string[] nevek = new string[5] {"Béla", "Jancsi", "Anna", "Bea", "Zakariás"};
            Array.Sort(nevek);
            int[] magassagok = new int[5];
            int max = int.MinValue;
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write(nevek[i] + " ");
                magassagok[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < magassagok.Length; i++)
            {
                sum = sum + magassagok[i];
            }
            Console.WriteLine($"Az átlagmagasság: {sum/magassagok.Length}");
           
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write(nevek[i]+" ");
            }
            int legmEmber = 0;;
            for (int i = 0; i < nevek.Length; i++)
            {
                if (magassagok[i] > max)
                {
                    max = magassagok[i];
                    legmEmber = i;
                }
            }
            Console.Write($"\nŐ a legmagasabb: {nevek[legmEmber]},{max}");
            for (int i = 0; i < magassagok.Length; i++)
            {
                for (int j = i; j < magassagok.Length; j++)
                {
                    if (magassagok[i] > magassagok[j])
                    {
                        int c = magassagok[i];
                        magassagok[i] = magassagok[j];
                        magassagok[j] = c;
                    }
                }
            }
            Console.Write("\nNövekvőbe sorrendbe:");
            for (int i = 0; i < magassagok.Length; i++)
            {
                Console.Write(magassagok[i] + " ");
            }
            Console.WriteLine("\n---------------------");

            Console.WriteLine("2-es feladat:");
            int[] tomb = new int[20];
            int ossz = 0;
            int megsz = 0;
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(50, 150);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int k = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = k;
                    }
                }
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
                
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                ossz = ossz + tomb[i];
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 10 == 0)
                {
                    megsz++;
                }
            }
            Console.WriteLine($"\nA tömb elemeinek összege: {ossz}");
            Console.WriteLine($"A tömb elemeinek átlaga: {ossz/tomb.Length}");
            Console.WriteLine($"Ennyi szám végződik 0-ra: {megsz}");

            Console.WriteLine("\n---------------------");

            Console.WriteLine("3-as feladat: ");
            int[] tomb2 = new int[20];
            int s = 9;
            for (int i = 0; i < tomb2.Length; i++)
            {
                int ps = r.Next(s, 100);
                tomb2[i] = ps;
                s = ps;
                Console.Write(tomb2[i] + " ");
            }
            Console.WriteLine("\n---------------------");

            Console.WriteLine("4-es feladat: ");

            string[] names = new string[10];
            for (int i = 0; i < names.Length; i++)
            
                Console.ReadKey();
            }
        }
    }
}
