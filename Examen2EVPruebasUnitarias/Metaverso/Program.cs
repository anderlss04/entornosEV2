using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();

            var normal = sistema.Divisible(sistema.num);
            var array = sistema.DivisibleArray(sistema.numA);
            
            Console.WriteLine($"El resultado es: {normal}");
            Console.WriteLine($"El resultado es: {array}");
        }
    }
}
