using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
    public class BaseballGlove : IShippable 
    {
        public decimal ShipCost
        {
            get
            { return 3.23M; }
            
        }
        public string Product
        {
            get { return "Baseball Glove"; }
        }
    }
}
