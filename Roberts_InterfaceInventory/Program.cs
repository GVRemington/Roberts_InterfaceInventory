// See https://aka.ms/new-console-template for more information

//Rayleen Roberts
//IT 112
//Notes: Worked this while loop around a lot. I've been trying breakpoints.
//       for whatever reason, this isn't letting me put breakpoints in the 
//       class, (or maybe I just don't know where to put them in the class),
//       I need to figure out if the information is going in and then I am erasing 
//       it, or if it isn't getting there in the first place. I'll keep going. 
//       update: It's 10:20 andI'm stymied.  I'm falling asleep over my keyboard,
//       it's not helping me find my error. Going to turn it in as is.  I feel like
//       the problem is either pathelogically simple, or glaringly horribly big.  Maybe
//       I did a good enough job that you can actually read what I did and tell me 
//       what I did wrong :)
//Behaviors not implemented: either the loop is not populating the array, or it is and 
//                           then the index is getting erased/replaced. I can iterate
//                           through the loops for the counts, and get the shipping cost
//                           of the one item that will show in the array...but I still have 
//                           an Array Population bug somewhere, still looking. 

using Roberts_InterfaceInventory;


ConsoleKeyInfo menuSelection;
Shipper myShipper = new Shipper();
bool keepGoing = true;

Console.WriteLine("\n");
Console.Write(ProductList.menu);
menuSelection = Console.ReadKey();
while (keepGoing)
{  
    switch (menuSelection.Key)
    {
        case > ConsoleKey.D0 and < ConsoleKey.D5:
            myShipper.whichItem(menuSelection);
            break;
        case ConsoleKey.D5 or ConsoleKey.D6:
            Console.WriteLine(myShipper.readArray(menuSelection));
            break;
        case ConsoleKey.D7:
            keepGoing = false;
            Console.WriteLine("\t\nGoodBye, Thank You For Shopping");
            Environment.Exit(0);
            break;
        default:Console.WriteLine("Invalid Selection, Please Try Again");
            break;
    }
    Console.WriteLine("\t\nPlease Make Another Selection...");
    menuSelection=Console.ReadKey();
    }
          
          
     








