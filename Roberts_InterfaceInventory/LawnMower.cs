using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
   public class LawnMower : IShippable
    {
        
        public decimal ShipCost
        {
            get
            { return 24.00M; }
            
        }
        public string Product
        {
            get { return "Lawn Mower"; }
            
        }
    }

    
}
