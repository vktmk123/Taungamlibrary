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
    public class ShipMenu
    {
        //Create new Ship 
        List<Ship> ship = new List<Ship>();
        Ship MyShip = new ShipDefau();
        Ship MyAlvin = new Alvin();
        Ship MyBathysphere = new Bathysphere();
        Ship MyFNRS = new FNRS();
        Ship customerShip;
        //Confirm the customer's order
        bool confirm = true;
        //Char will use to ask user Yes or No
        char YesNo = 'N';
        bool goihan = false;
        //Create a Customer's order Ship
        int chooseShip;
        int chooseDevice;


        public void ShowMenu()
        {
            Ship MyCabin = new Cabin(MyShip);
            Ship MyFrame = new Frame(MyShip);
            Ship MyRade = new Rada(MyShip);
            Ship MyPropeller = new Propeller(MyShip);
            Console.WriteLine("---- Submarine----");
            Console.WriteLine("== Submarine type ");
            Console.WriteLine($" \t{MyAlvin.GetDescription()}:          ${MyAlvin.CalculateCost()}");
            Console.WriteLine($" \t{MyBathysphere.GetDescription()}:    ${MyBathysphere.CalculateCost()}");
            Console.WriteLine($" \t{MyFNRS.GetDescription()}:           ${MyFNRS.CalculateCost()}");
            Console.WriteLine();
            Console.WriteLine("== Device ");
            Console.WriteLine($" \t{MyCabin.GetDescription()}:       ${MyCabin.CalculateCost()}");
            Console.WriteLine($" \t{MyFrame.GetDescription()}:       ${MyFrame.CalculateCost()}");
            Console.WriteLine($" \t{MyRade.GetDescription()}:        ${MyRade.CalculateCost()}");
            Console.WriteLine($" \t{MyPropeller.GetDescription()}:   ${MyPropeller.CalculateCost()}");
        }

        public void choiceShip()
        {
            do
            {
                try
                {
                    Console.Write(" Choose Ship:  ");
                    chooseShip = int.Parse(Console.ReadLine());
                    goihan = chooseShip < 0 || chooseShip > 3;
                    if (goihan)
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("just input number!");
                    choiceShip();
                }
            } while (goihan);
        }


        public void ShowShip()
        {
            Console.WriteLine("---- Submarine----");
            Console.WriteLine("== Submarine type ");
            Console.WriteLine($" (1) \t{MyAlvin.GetDescription()}:          ${MyAlvin.CalculateCost()}");
            Console.WriteLine($" (2) \t{MyBathysphere.GetDescription()}:    ${MyBathysphere.CalculateCost()}");
            Console.WriteLine($" (3) \t{MyFNRS.GetDescription()}:           ${MyFNRS.CalculateCost()}");
            Console.WriteLine();
            //choiceShip();
            //do
            //{
                try
                {
                    choiceShip();

                    while (confirm)
                    {
                        switch (chooseShip)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyAlvin.GetDescription()}:${MyAlvin.CalculateCost()}");
                                Console.ResetColor();
                                customerShip = new Alvin();
                                ship.Add(customerShip);
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyBathysphere.GetDescription()}:${MyBathysphere.CalculateCost()}");
                                Console.ResetColor();
                                customerShip = new Bathysphere();
                                ship.Add(customerShip);
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyFNRS.GetDescription()}:${MyFNRS.CalculateCost()}");
                                Console.ResetColor();
                                customerShip = new FNRS();
                                ship.Add(customerShip);
                                break;
                            case 4:
                            default:
                                Console.WriteLine("invalue");
                                break;
                        }
                        Console.Write("-Do you want to add more Device? (Y: Yes or N: No): ");
                        YesNo = char.Parse(Console.ReadLine());
                        if (YesNo == 'Y' || YesNo == 'y')
                        {
                            ShowDevice();
                        }
                        else
                        {
                            ShowShip();
                        }
                        break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Re-choose Ship");
                    ShowShip();
                }

            //} while (chooseShip != 4);
        }


        public void choiceDevice()
        {
            do
            {
                try
                {
                    Console.Write(" Add Device (Press 'Enter' to done):  ");
                    chooseDevice = int.Parse(Console.ReadLine());
                    goihan = chooseDevice < 0 || chooseDevice > 6;
                    if (goihan)
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch (System.Exception)
                {
                    confirm = false;
                    Result();
                }
            } while (goihan);
        }


        public void ShowDevice()
        {
            Ship MyCabin = new Cabin(MyShip);
            Ship MyFrame = new Frame(MyShip);
            Ship MyRade = new Rada(MyShip);
            Ship MyPropeller = new Propeller(MyShip);
            Console.WriteLine("== Device ");
            Console.WriteLine($" (1) \t{MyCabin.GetDescription()}:       ${MyCabin.CalculateCost()}");
            Console.WriteLine($" (2) \t{MyFrame.GetDescription()}:       ${MyFrame.CalculateCost()}");
            Console.WriteLine($" (3) \t{MyRade.GetDescription()}:        ${MyRade.CalculateCost()}");
            Console.WriteLine($" (4) \t{MyPropeller.GetDescription()}:   ${MyPropeller.CalculateCost()}");
            Console.WriteLine(" (5)    Undecor the ship ");
            Console.WriteLine(" (6)    rebuild the ship ");
            Console.WriteLine();
            choiceDevice();
            //do
            //{
                //choiceDevice();
                try
                {
                    //choiceDevice();
                    while (confirm)
                    {

                        switch (chooseDevice)
                        {
                            case 1:
                                customerShip = new Cabin(ship.Last());
                                ship.Add(customerShip);
                                Result();
                                Console.WriteLine("---------------------------------------------------");
                                break;
                            case 2:
                                customerShip = new Frame(ship.Last());
                                ship.Add(customerShip);
                                Result();
                                Console.WriteLine("---------------------------------------------------");
                                break;
                            case 3:
                                customerShip = new Rada(ship.Last());
                                ship.Add(customerShip);
                                Result();
                                Console.WriteLine("---------------------------------------------------");
                                break;
                            case 4:
                                customerShip = new Propeller(ship.Last());
                                ship.Add(customerShip);
                                Result();
                                Console.WriteLine("---------------------------------------------------");
                                break;
                            case 5:
                                RemoveDecor();
                                Result();
                                Console.WriteLine("---------------------------------------------------");
                                break;
                            case 6:
                                ShowShip();
                                break;
                            default:
                                break;
                        }
                        if (ship.Last().Activeenergy() <= 3000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Warning over activy energy! ");
                            Console.ResetColor();
                            Result();
                             //choiceDevice();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" Do you want to choce again ? (Y: Yes or N: No): ");
                            Console.ResetColor();
                            YesNo = char.Parse(Console.ReadLine());
                            if (YesNo == 'Y' || YesNo == 'y')
                            {
                                 ShowDevice();
                                //choiceDevice();
                                break;
                                //ShowShip();
                            }
                            else if (YesNo == 'N' || YesNo == 'n')
                            {
                                confirm = false;
                                Result();
                                break;
                            }
                        }
                        else
                        {
                            ShowDevice();
                            break;
                        }
                    }
                }
                catch (System.Exception)
                {
                    confirm = false;
                    Result();
                    //ShowShip();
                }
            //} while (chooseShip > 6 && chooseShip < 0);
        }

        public void Result()
        {
            Console.WriteLine("--- Customer order ---");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("--Ship--");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("---------Devices--");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Name: {0}",ship.Last().GetDescription());
            Console.WriteLine("Weight :{0} (Tons)", ship.Last().GetWeight());
            Console.WriteLine("Depth Limit:{0} (M)", ship.Last().DepthLimit());
            Console.WriteLine("Time Work:{0} (H)",ship.Last().TimeWork());
            Console.WriteLine("Activeenergy: {0} (Kw)",ship.Last().Activeenergy());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("--Price: ");
            Console.ResetColor();
            Console.WriteLine("${0}",ship.Last().CalculateCost());
            Console.WriteLine("Thank you for using our service!");
        }

        public void RemoveDecor()
        {
            Console.WriteLine("Remove");
            ship.RemoveAt(ship.Count - 1);  
        }

    }
}
