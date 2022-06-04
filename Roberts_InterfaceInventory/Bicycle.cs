using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
    public class Bicycle : IShippable
    {
        
        public decimal ShipCost
        {
            get
            { return 9.50M; }
            
        }
        public string Product
        {
            get { return "Bicycle"; }  
        }

    }
        
} 