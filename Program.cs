using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string linea = Console.ReadLine();
            float num1 = float.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            float num2 = float.Parse(linea);

            if (num1 > num2)
            {
                float suma = num1 + num2;
                float dif = num1 - num2;
                Console.WriteLine("La suma de estos números es:");
                Console.WriteLine(suma);
                Console.WriteLine("La diferencia es:");
                Console.WriteLine(dif);
            }
            else
            {
                float prod = num1 * num2;
                float div = num1 / num2;
                Console.WriteLine("El producto de estos números es:");
                Console.WriteLine(prod);
                Console.WriteLine("La división es:");
                Console.WriteLine(div);
            }
            Console.ReadKey();
        }

    }
}