using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Car
    {
        private string brand, licensePlateNumber;
        private int startingPositionX , startingPositionY;

        public Car(string brand, string licensePlateNumber, int startingPositionX, int startingPositionY)
        {
            this.brand = brand;
            this.licensePlateNumber = licensePlateNumber;
            this.startingPositionX = startingPositionX;
            this.startingPositionY = startingPositionY;
        }
        public void setBrand(string brand)
        {
            this.brand=brand;
        }
        public string getBrand()
        {
            return brand;
        }
        public void setLicensePlateNumber(string licensePlateNumber) 
        {
            this.licensePlateNumber = licensePlateNumber; 
        }
        public string getLicensePlateNumber()
        {
            return licensePlateNumber;
        }
        public void setStartingPositionX(int startingPositionX)
        {
            this.startingPositionX = startingPositionX;
        }
        public int getStartinPositionX()
        {
            return startingPositionX;
        }
        public void setStartingPositionY(int startingPositionY)
        {
            this.startingPositionY = startingPositionY;
        }
        public int getStartinPositionY()
        {
            return startingPositionY;
        }
        
        public void accelerate()
        {
            Console.WriteLine("The car is accelerating");
        }
        public void move()
        {
            Console.WriteLine("The car is moving");
        }
        public void park()
        {
            Console.WriteLine("The car is parking");
        }
        public void slowDown()
        {
            Console.WriteLine("The car is slowing down");
        }
    }
}
