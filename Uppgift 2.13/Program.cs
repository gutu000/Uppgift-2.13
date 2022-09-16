using System;

namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön summa 1");
            string Ett = Console.ReadLine();
            int Person1 = Convert.ToInt32(Ett);

            Console.WriteLine("Lön summa 2");
            string två = Console.ReadLine();
            int Person2 = Convert.ToInt32(två);

            Console.WriteLine("Lön summa 3");
            string tre = Console.ReadLine();
            int Person3 = Convert.ToInt32(tre);
            int medellön = Person1 + Person2 + Person3 / 3;
            Console.Write("Medellönen blir ");
            Console.WriteLine(medellön);
            //hej



        }
    }
}