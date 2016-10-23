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
    }

   

}
