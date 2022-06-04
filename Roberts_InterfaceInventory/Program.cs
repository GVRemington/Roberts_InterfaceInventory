// See https://aka.ms/new-console-template for more information

//Rayleen Roberts
//IT 112
//Notes: Worked this while loop around a lot. I've been trying breakpoints.
//       for whatever reason, this isn't letting me put breakpoints in the 
//       class, (or maybe I just don't know where to put them in the class),
//       I need to figure out if the information is going in and then I am erasing 
//       it, or if it isn't getting there in the first place. I'll keep going. 
//Behaviors not implemented: either the loop is not populating the array, or it is and 
//                           then the index is getting erased/replaced. I can iterate
//                           through the loops for the counts, and get the shipping cost
//                           of the one item that will show in the array...but I still have 
//                           and Array Population bug somewhere, still looking. 

using Roberts_InterfaceInventory;


ConsoleKeyInfo menuSelection;
Shipper myShipper = new Shipper();
bool keepGoing = true;

Console.WriteLine("\n");
Console.Write(ProductList.menu);
menuSelection = Console.ReadKey();
while (keepGoing)
    {
    if (menuSelection.Key == ConsoleKey.D7)
    {
        keepGoing = false;
        Console.WriteLine("\tGoodBye");
        Environment.Exit(0);
    }
    else if (menuSelection.Key > ConsoleKey.D0 && menuSelection.Key < ConsoleKey.D5)
    {
        myShipper.whichItem(menuSelection);
    }
    else if (menuSelection.Key == ConsoleKey.D5 || menuSelection.Key == ConsoleKey.D6)
    {
        Console.WriteLine(myShipper.readArray(menuSelection));
    }
        Console.Write("\n\tPlease Make Another Selection");
        menuSelection = Console.ReadKey();

    }
          
          
     








