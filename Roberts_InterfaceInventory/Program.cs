// See https://aka.ms/new-console-template for more information

//Rayleen Roberts
//IT 112
//Notes: Worked this while loop around a lot. I thought of one 
       //more thing...splitting the two "returns" away from the ADD
       //and having them be their own method.  But then I ran out of
       //time to complete that thing. After I turn this in, I'm going 
       //to fiddle with it and see if that works, but I won't update it
       //on gitHub...I know that would be cheating. I'm also disappointed
       //that I couldn't get rid of reading evaluating readkey's in main...or at 
       //least I couldn't figure out how. 
//Behaviors not implemented: none of them because I never could get my loop to do 
                           //what I wanted...but I think if I could, populating the array
                           //and evaluating it would have worked...except like I said above
                           //I now think I needed to separate reading the array and adding 
                           //to the array into two methods. Did the best I coudl with time
                           //allowed and health issues going on.  Beter luck to me next time :)

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
            }
        else
            {
                myShipper.whoTheHellKnows(menuSelection);
            }
        
        menuSelection = Console.ReadKey();

    }
          
          
     








