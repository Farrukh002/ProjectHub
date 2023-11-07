using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public enum Availability { Available, NotAvailable }

    internal class Product
    {
        private string code, name;
        private DateTime dateOfOutcome;
        private bool isAvailable;
        private double price;

        public void setAvailability(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }
        public Availability getAvailability()
        {
            return isAvailable ? Availability.Available : Availability.NotAvailable;
        }
         public void setCode(string code)
        {
            this.code = code;   
        }
        public string getCode()
        {
            return code;
        }
        public void setDateOfOutcome(DateTime dateOfOutcome)
        {
            this.dateOfOutcome = dateOfOutcome;
        }
        public DateTime getDateOfOutcome()
        {
            return dateOfOutcome;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;    
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return string.Format("Code of product: {0}\nDate of Outcome: {1}\nName of product: {2} " +
                "\nPrice of Product: {3}", getCode(), getDateOfOutcome(), getName(), getPrice());
        }

    }
}
