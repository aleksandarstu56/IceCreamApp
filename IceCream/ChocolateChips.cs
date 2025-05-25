using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamApp
{
    public class ChocolateChips : IceCreamDecorator
    {
        public ChocolateChips(IceCream iceCream) : base(iceCream) { }

        public override string GetDescription() => _iceCream.GetDescription() + " with chocolate chips";
    }
}
