using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taungamlibrary
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public double Weight {get; set; }
        public double Displacement {get; set; }
        public double Tonnage {get; set; }
        public double Price {get; set; }
        public double Power {get; set; }

        public abstract string GetDescription();
        public abstract double CalculateCost();
        public abstract double GetTonnege();
        public abstract double GetWeight();
        public abstract double GetDisplacement();
        public abstract double DepthLimit();
        public abstract double Activeenergy();
        public abstract double TimeWork();
    }
}
