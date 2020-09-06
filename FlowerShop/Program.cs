using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    enum FLOWER
    {
        Rose = 1,
        Orchid,
        Tulip
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool SwitchMarker = true;
            Console.WriteLine("Select flowers for your bunch.");
            do
            {
                Console.WriteLine($"{(int)FLOWER.Rose}. Rose");
                Console.WriteLine($"{(int)FLOWER.Orchid}. Orchid");
                Console.WriteLine($"{(int)FLOWER.Tulip}. Tulip");
                Console.WriteLine($"If that's enough press 0.");
                FLOWER UserChoice = (FLOWER)int.Parse(Console.ReadLine());
                FlowerCreator(UserChoice);
                if (UserChoice == default)
                {
                    SwitchMarker = false;
                }
            } while (SwitchMarker);
            double Sum = CreateBunch();

            Console.WriteLine($"The cost of the bunch is {Sum} uah.");

        }
        public static void FlowerCreator(FLOWER choice)
        {
            switch (choice)
            {
                case FLOWER.Rose:
                    Rose r = new Rose();
                    BunchCreator.flowers.Add(r);
                    break;
                case FLOWER.Orchid:
                    Orchid o = new Orchid();
                    BunchCreator.flowers.Add(o);
                    break;
                case FLOWER.Tulip:
                    Tulip t = new Tulip();
                    BunchCreator.flowers.Add(t);
                    break;
                default:
                    return;
            }
        }

        public static double CreateBunch()
        {
            double sum = 0;
            foreach (var flower in BunchCreator.GetFlowers())
            {
                sum += flower.price;
            }
            return sum;
        }
    }
}
