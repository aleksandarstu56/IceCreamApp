using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{

        class Program
        {
            static void Main()
            {
            IceCreamShop shop = IceCreamShop.Instance;

            while (true)
            {
                Console.WriteLine("Choose ice cream: 'vanilla', 'chocolate', 'banana' or type 'exit':");
                string type = Console.ReadLine().ToLower();

                if (type == "exit")
                    break;

                Console.WriteLine("Choose Addon:");
                Console.WriteLine("1 - No addon");
                Console.WriteLine("2 - Chocolate topping");
                Console.WriteLine("3 - Chocolate chips");

                string addonChoice = Console.ReadLine();
                IceCreamAddon addon;

                switch (addonChoice)
                {
                    case "2":
                        addon = IceCreamAddon.ChocolateTopping;
                        break;
                    case "3":
                        addon = IceCreamAddon.ChocolateChips;
                        break;
                    default:
                        addon = IceCreamAddon.None;
                        break;
                }

                try
                {
                    var order = shop.OrderIceCream(type, addon);
                    Console.WriteLine("Ordered ice cream: " + order.GetDescription());
                    Console.WriteLine("-----");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        }
    
}
