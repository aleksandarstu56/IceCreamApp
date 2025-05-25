using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{
    public class IceCreamFactory
    {
        public IceCream CreateIceCream(string IceCreamtype)
        {
            switch (IceCreamtype.ToLower())
            {
                case "vanilla":
                    return new VanillaIceCream();
                case "chocolate":
                    return new ChocolateIceCream();
                case "banana":
                    return new BananaIceCream();
                default:
                    throw new ArgumentException("invalid ice cream");
            }
        }
    }
}
