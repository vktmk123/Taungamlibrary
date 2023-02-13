using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taungamlibrary
{
    public class ShipDecorator : Ship
    {
        protected Ship _ship;
        public ShipDecorator(Ship ship)
        {
            _ship = ship;
        }
        public override double Activeenergy()
        {
            return _ship.Activeenergy();
        }

        public override double CalculateCost()
        {
            return _ship.CalculateCost();
        }

        public override double DepthLimit()
        {
            return _ship.DepthLimit();
        }

        public override string GetDescription()
        {
            return _ship.GetDescription();
        }

        public override double GetDisplacement()
        {
            return _ship.GetDisplacement();
        }

        public override double GetTonnege()
        {
            return _ship.GetTonnege() - GetDisplacement() - GetWeight(); ;
        }
        public override double GetWeight()
        {
            return _ship.GetWeight();
        }
        public override double TimeWork()
        {
            return _ship.TimeWork();
        }
    }
}
