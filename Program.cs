using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        struct EngineStruct
        {

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

                Mercedes m1 = new Mercedes();
                //m.PrintMercedesLogo();
                //m1.PrintNewMercedes(Mercedes.staticcounter++);
                //Mercedes m2 = new Mercedes();
                //Mercedes m3 = new Mercedes();
                //Mercedes m4 = new Mercedes();
                //m2.PrintNewMercedes(Mercedes.staticcounter++);
                //m3.PrintNewMercedes(Mercedes.staticcounter++);
                //m4.PrintNewMercedes(Mercedes.staticcounter++);

                //Mercedes.StartEngine();

                Mercedes asa = new Mercedes();
                asa.ShowRemainingNoOFKM(10, 7);

                double numberOfKilometerLeft;
                numberOfKilometerLeft = asa.ShowRemainingNoOfKM(10, 7);
                Console.WriteLine("Numarul de km ramasi: " + numberOfKilometerLeft);
                Console.ReadKey();


            }

            static int counter;

            static void PrintLogo()
            {
                Console.WriteLine("I am learning C#");
                Console.WriteLine("C#is great");
                PrintLogo2();
            }
            static void PrintLogo(int i)
            {
                Console.WriteLine("I am another printlogo");
            }
            static void PrintLogo2()
            {
                counter++;
                if (counter == 3) return;
                Console.WriteLine("PrintLogo2");
                PrintLogo();
            }
        }
    }
}


