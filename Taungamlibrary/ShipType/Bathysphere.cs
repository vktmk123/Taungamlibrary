using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taungamlibrary.ShipType
{
    public class Bathysphere : Ship
    {
        public Bathysphere()
        {
            Name = "Bathysphere";
            Weight = 3000;
            Displacement = 2000;
            Tonnage = 10000;
            Power = 20000;
            Price = 5000;
        }

        public override double Activeenergy()
        {
            return Power;
        }

        public override double CalculateCost()
        {
            return Price;
        }

        public override double DepthLimit()
        {
            return Weight / 10.3;
        }

        public override string GetDescription()
        {
            return Name;
        }

        public override double GetDisplacement()
        {
            return Displacement;
        }

        public override double GetTonnege()
        {
            return Tonnage;
        }

        public override double GetWeight()
        {
            return Weight;
        }
        public override double TimeWork()
        {
            return (int)(Power / 1000);
        }
    }
}
