using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_InterfaceInventory
{
   public class Crackers : IShippable 
    {
        private decimal shipCost;
        private string productName;

        public decimal ShipCost
        {
            get
            { return shipCost; }
            set
            { shipCost = 0.57M; }
        }
        public string Product
        {
            get { return productName; }
            set { productName = "Crackers"; }
        }
    }
}
