using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taungamlibrary;
using Taungamlibrary.Decorator;
using Taungamlibrary.ShipType;

namespace MenuTau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ship MyShip = new FNRS();
            //MyShip = new Cabin(MyShip);
            //MyShip = new Rada(MyShip);
            //MyShip = new Cabin(MyShip);
            //MyShip = new Propeller(MyShip);
            //MyShip = new Frame(MyShip);

            //Console.WriteLine(MyShip.GetDescription());
            //Console.WriteLine("Price : {0} ($)", MyShip.CalculateCost());
            //Console.WriteLine("Weight :{0} (Tons)", MyShip.GetWeight());
            //Console.WriteLine("Depth Limit = {0} (m)", MyShip.DepthLimit());
            //Console.WriteLine("Active energy = {0} (Kw)", MyShip.Activeenergy());
            //Console.WriteLine("Time active  = {0} (H)", MyShip.TimeWork());

            ShipMenu shipMenu = new ShipMenu();
            shipMenu.ShowMenu();
            shipMenu.ShowShip();

            Console.WriteLine("************GCH1003**********");

            Console.ReadLine();
        }
    }
}
