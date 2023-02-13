using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taungamlibrary.Decorator
{
    public class Propeller : ShipDecorator
    {
        public Propeller(Ship ship) : base(ship)
        {
            Name = "Propeller";
            Weight = 1000;
            Price = 10000;
            Power = 3000;
        }
        public override string GetDescription()
        {
            if (_ship.Activeenergy() <= 3000)
            {
                return _ship.GetDescription();
            }
            else
            {
                return String.Format("{0}, {1}", _ship.GetDescription(), Name);
            }

        }
        public override double Activeenergy()
        {
            if (_ship.Activeenergy() <= 3000)
            {
                return _ship.Activeenergy();
            }
            else
            {
                return _ship.Activeenergy() - (Power + GetWeight() * 10 / 100);
            }

        }

        public override double CalculateCost()
        {
            if (_ship.Activeenergy() <= 3000)
            {
                return _ship.CalculateCost();
            }
            else
            {
                return _ship.CalculateCost() + Price;
            }
        }
        public override double GetWeight()
        {
            if (_ship.Activeenergy() <= 3000)
            {
                return _ship.GetWeight();
            }
            else
            {
                return _ship.GetWeight() + Weight;
            }
        }
        public override double DepthLimit()
        {
            if (_ship.Activeenergy() <= 3000)
            {
                return _ship.DepthLimit();
            }
            else
            {
                return _ship.DepthLimit() + Weight / 10.3;
            }

        }
        public override double GetDisplacement()
        {
            return _ship.GetDisplacement();
        }

        public override double GetTonnege()
        {
            return _ship.GetTonnege();
        }
    }
}
