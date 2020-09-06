using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Flower
    {
        public double price;
        public string color;

    }

    class Rose : Flower
    {
        public new double price = 10;
        public bool spinescent;
    }

    class LongRose : Rose
    {
        public new double price = 13;
    }

    class Orchid : Flower
    {

        private bool InAPot;
        public double Price 
        { 
            get 
            {
                if (InAPot)
                {
                    return 20;
                }
                else return 18;
            }
        }
    }
}
