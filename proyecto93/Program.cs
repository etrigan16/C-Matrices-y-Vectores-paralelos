using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto93
{
    class TemeperaturaMedia
    {
        private string[] paises;
        private int[,] tempMen;
        private int[] tempTrim;

        public void Cargar()
        {
            paises = new string[4];
            tempMen = new int[4, 3];
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingrese el pais: ");
                paises[f] = Console.ReadLine();
                for (int c = 0; c < tempMen.GetLength(1); c++)
                {
                    Console.Write("Ingrese la temperatura media mensual: ");
                    tempMen[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void ImprimirTempMensuales()
        {
            Console.WriteLine("Paises y sus temperaturas medias mensual");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Pais: " + paises[f] + " - ");
                for (int c = 0; c < tempMen.GetLength(1); c++)
                {
                    Console.Write(tempMen[f, c] + "  ");

                }
                Console.WriteLine();
            }
        }
        public void CalcularTempMedia()
        {
            tempTrim = new int[4];
           
            for (int f = 0; f<tempMen.GetLength(0);f++)
            {
                int mediatrim = 0;
                for (int c=0;c<tempMen.GetLength(1);c++)
                {
                    mediatrim = mediatrim + tempMen[f, c];
                    
                }
                tempTrim[f] = mediatrim/3;
            }
           
        }
        public void ImprimirTempMayorTrim()
        {
            int may = tempTrim[0];
            string nom = paises[0];
            for(int f=0;f<paises.Length;f++)
            {
                if(tempTrim[f]>may)
                {
                    may = tempTrim[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("Pais con la temperatura trimestral mayor " + nom + " con una temperatura de " + may);
        }
        public void ImprimirMediaTrimestral()
        {
            Console.WriteLine("Temperaturas promedio trimestral");
            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine(paises[f] + "  " + tempTrim[f]);
                
            }
        }
        static void Main(string[] args)
        {
            TemeperaturaMedia tm = new TemeperaturaMedia();
            tm.Cargar();
            tm.ImprimirTempMensuales();
            tm.CalcularTempMedia();
            tm.ImprimirMediaTrimestral();
            tm.ImprimirTempMayorTrim();
            Console.ReadKey();
        }
    }
}
