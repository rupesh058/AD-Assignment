using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // this is an abstract class so other device classes will inherit from it
    public abstract class ElectronicDevice
    {
        // private fields for storing brand name and price (encapsulation)
        private string brand;
        private double price;

        // public property to access and change brand value
        public string Brand
        {
            get { return brand; }     // return brand name
            set { brand = value; }    // set brand name
        }

        // public property to access and change price value
        public double Price
        {
            get { return price; }     // return price
            set { price = value; }    // set price
        }

        // constructor to set initial brand and price when object is created
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;   // assigning brand value
            this.price = price;   // assigning price value
        }

        // abstract method - child classes must override this method
        public abstract void ShowInfo();
    }
}
