using System;
using System.Collections.Generic;

namespace Week_5
{
    public class ElectronicsStore
    {
        // list to store all electronic devices (like laptop or smartphone)
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // method to add a new device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);   // adding device to list
            Console.WriteLine(device.Brand + " added to store.");
        }

        // method to remove a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            // checking if device exists in list
            if (devices.Contains(device))
            {
                devices.Remove(device);   // removing device
                Console.WriteLine(device.Brand + " removed from store.");
            }
            else
            {
                Console.WriteLine("Device not found.");   // when device is not inside list
            }
        }

        // method to show details of all devices in the store
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Devices in Store ---");

            // looping through each device in the list
            foreach (var device in devices)
            {
                device.ShowInfo();   // calling the ShowInfo() method (polymorphism)

                // Downcasting to check if the device is Laptop2
                if (device is Laptop2 laptop)
                {
                    laptop.TurnOnBattery();   // calling laptop-specific method
                }

                // Downcasting to check if the device is Smartphone2
                if (device is Smartphone2 phone)
                {
                    phone.EnableCamera();    // calling smartphone-specific method
                }

                Console.WriteLine(); // just extra line for clean output
            }
        }
    }
}
