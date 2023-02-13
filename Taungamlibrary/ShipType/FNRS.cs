using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taungamlibrary.ShipType
{
    public class FNRS : Ship
    {
        public FNRS()
        {
            Name = "FNRS";
            Weight = 1000;
            Displacement = 800;
            Tonnage = 5000;
            Power = 12000;
            Price = 3000;
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
