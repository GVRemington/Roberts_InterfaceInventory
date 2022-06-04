using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
    public class Shipper
    {
        ConsoleKeyInfo _menuKey;
        //Shipper myShipper = new Shipper();
        IShippable[] myShipment = new IShippable[10];

        public ConsoleKeyInfo whoTheHellKnows(ConsoleKeyInfo shitComingFromMain)
        {
            _menuKey = shitComingFromMain;
            return _menuKey;
        }

        public void whichItem(ConsoleKeyInfo menuSelection)
        {
            ConsoleKeyInfo MenuSelection = menuSelection;
            int i = 0;
            if (myShipment[i] == null)
                {
                    switch (MenuSelection.Key)
                    {
                        case ConsoleKey.D1:
                            Bicycle bob = new Bicycle();
                            myShipment[i] = bob;
                            i++;
                            break;
                        case ConsoleKey.D2:
                            LawnMower fred = new LawnMower();
                            myShipment[i] = fred;
                            i++;
                            break;
                        case ConsoleKey.D3:
                            BaseballGlove ralph = new BaseballGlove();
                            myShipment[i] = ralph;
                            i++;
                            break;
                        case ConsoleKey.D4:
                            Crackers crackHead = new Crackers();
                            myShipment[i] = crackHead;
                            i++;
                            break;
                    }
                }
                else
                {
                    return;
                }
            
        }


        public string readArray(ConsoleKeyInfo _menuSelection)
        {
            int howManyBikes = 0;
            int howManyLawnMowers = 0;
            int howManyGloves = 0;
            int howManyCrackers = 0;
            decimal shippingTotal = 0;
            int i = 0;
            string outPut;
            switch (_menuSelection.Key)
            {
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
                        outPut = "\n\t" + howManyBikes + " Bikes\n" +
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
            }
            return string.Empty;
        }
    }
}




