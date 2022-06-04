using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
    public class Shipper
    {
        private ConsoleKeyInfo _menuKey;
        public ConsoleKeyInfo whoTheHellKnows(ConsoleKeyInfo shitComingFromMain)
        {
            _menuKey = shitComingFromMain;
            return _menuKey;
        }

        public string dealWithTheShitComingFromMain(ConsoleKeyInfo menuSelection )
            {
                ConsoleKeyInfo MenuSelection = menuSelection;
                IShippable[] myShipment = new IShippable[10];
                int howManyBikes = 0;
                int howManyLawnMowers = 0;
                int howManyGloves = 0;
                int howManyCrackers=0;
                decimal shippingTotal = 0;
                int i = 0;
                string outPut;
                //bool keepGoing = true;

            //while (keepGoing)
            //{
                //I have enought switch statements here to choke a horse
                //but I still think they look nicer than if/else

                switch (MenuSelection.Key)
                {
                    case ConsoleKey.D1:
                        myShipment[i] = new Bicycle();
                        i++;
                        break;
                    case ConsoleKey.D2:
                        myShipment[i] = new LawnMower();
                        i++;
                        break;
                    case ConsoleKey.D3:
                        myShipment[i] = new BaseballGlove();
                        i++;
                        break;
                    case ConsoleKey.D4:
                        myShipment[i] = new Crackers();
                        i++;
                        break;
                    case ConsoleKey.D5:
                        foreach (IShippable thing in myShipment)
                        {
                            switch (thing.Product)
                            {// I remember you said I didn't have to get this complicated
                             // but the cleaner way is escaping me at this moment
                                case "Bicyle":
                                    howManyBikes++;
                                    break;
                                case "Lawn Mower":
                                    howManyLawnMowers++;
                                    break;
                                case "Baseball Glove":
                                    howManyGloves++;
                                    break;
                                case "Crackers":
                                    howManyCrackers++;
                                    break;
                            }
                            outPut = "\t" + howManyBikes + " Bikes\n" +
                                        "\t" + howManyLawnMowers + " Lawn Mowers\n" +
                                        "\t" + howManyGloves + " Baseball Gloves\n" +
                                        "\t" + howManyCrackers + " Boxes of Crackers\n";
                            return outPut;

                        }
                        break;
                    case ConsoleKey.D6:
                        foreach (IShippable thing in myShipment)
                        {
                            shippingTotal = shippingTotal + thing.ShipCost;
                            outPut = "\tShipping Total:" + shippingTotal;
                            return outPut;
                        }
                        break;
                    //case ConsoleKey.D7:
                    //    keepGoing = false;
                    //    outPut = "GoodBye,Thank You For Shopping";
                    //    return outPut;
                    default:
                        outPut = "Invalid Selection, Please Try Again";
                        return outPut;
                }//MenuSelection Switch
                
            //}
            
            return  string.Empty;
            
        }

        public string menu()
        {
            string menu = 
                "\t1: Add a Bicycle to the Shipment        (shipping cost: $9.50)\n" +
                "\t2: Add a Lawn Mower to the Shipment     (shippping Cost: $24.00)\n" +
                "\t3: Add a Baseball Glove to the Shipment (shipping cost: $3.23)\n" +
                "\t4: Add Crackers to the Shipment         (shipping cost $0.57)\n" +
                "\t5: List Shipment Items\n" +
                "\t6: Compute Shipping Charges\n" +
                "\t7: Exit ";
            return menu;
        }


    }
}
