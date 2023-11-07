using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneApp
{
     class RandomPassenger
    {
       
        private string[] firstNamesFemale = { "Alexandra", "Alison", "Maria", "Sophie", "Wanda" },
        firstNamesMale = { "Brandon", "David", "Gordon", "Jonathan", "Peter" },
        lastNames = { "Abraham", "Campbell", "Ellison", "Henderson", "Johnston" };
        private Random rnd = new Random();

        private string generateElementOf(string[] strArray)
        {
            return strArray[rnd.Next(strArray.Length)];
        }
        private Gender generateGender()
        {
            return rnd.Next(2) == 0 ? Gender.Male : Gender.Female;  
        }
        private int generateAge()
        {
            return rnd.Next(10, 90);
        }
        private string generateTravelID()
        {
            return rnd.Next(1, 100) + ".";
        }
        public Passenger generatePassenger()
        {
            Passenger passenger = new Passenger();  
            passenger.Gender = generateGender();
            passenger.Age = generateAge();
            passenger.TravelID = generateTravelID();
            passenger.FirstName = generateElementOf(passenger.Gender.Equals(Gender.Male) ?
                firstNamesMale : firstNamesFemale);
            passenger.LastName = generateElementOf(lastNames);
            
            return passenger;
        }

    }
}
