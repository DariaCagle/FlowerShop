using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public abstract class Flower
    {
        public double price;
        public string color;

    }

    class Rose : Flower
    {
        public Rose()
        {
            price = 10;
            spinescent = true;
        }
        public bool spinescent;
    }

    class LongRose : Rose
    {
        public LongRose()
        {
            price = 13;
        }
    }

    class Orchid : Flower
    {
        public Orchid()
        {
            price = 18;
        }
        private bool InAPot;
        public double Price 
        { 
            get 
            {
                if (InAPot)
                {
                    return 20;
                }
                else return price;
            }
        }
    }

    class Tulip : Flower
    {
        public Tulip() 
        {
            price = 7;
        }
        new string color;
    }
}
