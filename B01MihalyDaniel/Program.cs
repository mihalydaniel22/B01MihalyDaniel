using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01MihalyDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomb = new int[];

            Beolvasas();

            Minimumertek();

            Egyediek();

            Console.ReadKey();
        }

        static void Minimumertek()
        {
            int min = 0;
            for (int i = 0; i > tomb.Length; i++)
            {
                min++;
            }
            Console.WriteLine("A minimum: {0}", min);
        }

        static void Beolvasas()
        {           
            StreamReader olvas = new StreamReader("adatok.dat");
        }

        static void Egyediek()
        {
            Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", egyedi);
            StreamWriter iro = new StreamWriter("egyediek.txt");
        }
    }
}
