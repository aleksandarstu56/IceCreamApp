using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{
    public class IceCreamShop
    {
        private static IceCreamShop _instance;

        private IceCreamFactory _factory;

        private IceCreamShop()
        {
            _factory = new IceCreamFactory();
        }

        public static IceCreamShop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IceCreamShop();
                }

                return _instance;
            }
        }

        public IceCream OrderIceCream(string type, IceCreamAddon addon)
        {
            IceCream iceCream = _factory.CreateIceCream(type);

            switch (addon)
            {
                case IceCreamAddon.ChocolateTopping:
                    iceCream = new ChocolateTopping(iceCream);
                    break;
                case IceCreamAddon.ChocolateChips:
                    iceCream = new ChocolateChips(iceCream);
                    break;
                case IceCreamAddon.None:
                default:
                    break;
            }

            return iceCream;
        }
    }

}
