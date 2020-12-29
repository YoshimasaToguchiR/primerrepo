using System;

namespace primerrepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el num A:");
            var a = Convert.ToInt32( Console.ReadLine());
             Console.WriteLine("Escribe el num B:");
            var b = Convert.ToInt32( Console.ReadLine());
            var c = a + b;
            Console.WriteLine("La suma es: "+ c);
        }
    }
}
