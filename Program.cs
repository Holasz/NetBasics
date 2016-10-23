using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        struct EngineStruct
        {
        }

        static void Main(string[] args)
        {
            //instantiam clasa Mercedes  
            Mercedes mercedes = new Mercedes();
            EngineStruct engine = new EngineStruct();
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();
            //AbstractCar aCar = new AbstractCar();
            Console.WriteLine("This is my first C# project!"); // afisam un mesaj in consola 
            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);

           // Console.WriteLine("Mercedes is " + mercedes._price);
            //Console.WriteLine(mercedes.type); ii protected si nu poate fi apelat aici
            Console.WriteLine("mercedes color is " + mercedes.color);
            Console.ReadKey();
        }
    }
}
