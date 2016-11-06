using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    // mostenim clasa AbstractCar
    public class  Mercedes : AbstractCar
    {
        public string Description;
        public int Price;
        private string _description;
        private int _price;
        protected string type;
        protected int TVA;
        internal string color;
        internal int speed;   
        // constructor
        public Mercedes()
        {
            Description = "E Class";
            Price =67000;
            _description = "new description";
            _price = 60000;
            type = "C";
            TVA = 20;
            color = "blue";
            speed = 4;

        }
        private int counter;

        public void PrintMercedesLogo()
        {
            counter++;
            if (counter == 3) return;
            Console.WriteLine("This is from Mercedes");
            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c)
        {
            if (c == 3) return;
            Console.WriteLine("Mercedes No = " + c);
        }
        public static int staticcounter;

        public static void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }

        public double ShowRemainingNoOfKM(double noOfFuelLiters, double Consumption)
        {
            //Console.WriteLine("Remaining km:" + noOfFuelLiters / Consumption * 100);
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;
            return result;
        }

        internal void ShowRemainingNoOFKM(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

}

