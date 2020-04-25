using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombrePersonas = new string [10];

            for (int i = 0; i < nombrePersonas.Length; i++)
            {
                Console.Write("Introduzca el nombre de la persona " + (i + 1) + ":");
                nombrePersonas[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Los nombres de personas ingresadas son:");

            foreach (string i in nombrePersonas)
            {
                Console.WriteLine(i);
            }
        }
    }
}
