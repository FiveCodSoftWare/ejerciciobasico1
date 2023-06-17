using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobasico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int suma, restar, multiplicar, mod;
            float dividir;

            Console.WriteLine("Ingrese numero 1: ");
            n1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2:");
            n2 =Convert.ToInt32(Console.ReadLine());

            suma = n1 + n2;
            restar=n1- n2;
            multiplicar = n1 * n2;
            mod = n1 % n2;
            dividir = n1 / n2;

            Console.WriteLine("La Suma del numero 1 y numero 2 es: "+suma);
            Console.WriteLine("La resta del numero 1 numero 2 es: " + restar);
            Console.WriteLine("La multiplicación del numero 1 y numero 2 es: " + multiplicar);
            Console.WriteLine("El mod del numero numero 1 numero 2 es: " + mod);
            Console.WriteLine("La división del numero 1 y numero 2 es: " + dividir);
            Console.ReadKey();

        }
    }
}
