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
            int tomb[] = new int[];

            beolvasas();

            Minimumertek();
        }

        static void Minimumertek()
        {
            int min = 0;
            for (int i = 0; i > tomb.Length; i++)
            {
                min++;
            }
        }

        static void beolvasas()
        {
            StreamReader olvas = new StreamReader("adatok.dat");
        }
    }
}
