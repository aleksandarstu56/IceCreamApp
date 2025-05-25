using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{
    public class ChocolateTopping : IceCreamDecorator
    {
        public ChocolateTopping(IceCream iceCream) : base(iceCream) { }

        public override string GetDescription() => _iceCream.GetDescription() + " with chocolate topping";
    }
}
