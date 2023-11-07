using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace StaffApp
{
    internal class Program
    {
        private List<Member> members = new List<Member>()
        {
            // ':' and '=' symbols are interchangeable in this context.
             new Member(
                id: 21,
                dept: Department.Marketing,
                name: "Mark B. Harbour",
                grade: 6,
                salary: 20000,
                bonusRate: null,
                homePhone: "973-475-1512",
                workPhone: "937-823-2348",
                address: new Address()
                {
                    Type = AddressType.Postal,
                    Street = "3971 Ingram Street",
                    City = "Dayton",
                    State = "Ohio(OH)",
                    Zip = 45402,
                    Country = "USA",
                }),
             new Member(
                id: 23,
                dept: Department.Sales,
                name: "Charles M Stewart",
                grade: 6,
                salary: 22000,
                bonusRate: 0.03,
                homePhone: "740-803-7350",
                workPhone: "740-272-9206",
                address: new Address()
                {
                    Type = AddressType.Postal,
                    Street = "3483",
                    City = "Delaware",
                    State = "Ohio(OH)",
                    Zip = 43015,
                    Country = "USA",
                }),
              new Member(
                id: 24,
                dept: Department.Sales,
                name: "Liz Elbow",
                grade: 5,
                salary: 22500,
                bonusRate: 0.02,
                homePhone: "863-474-6774",
                workPhone: "305-201-9879",
                address: new Address()
                {
                    Type = AddressType.Permanent,
                    Street = "1732 Single Street",
                    City = "Cambridge",
                    State = "Massachusetts(MA)",
                    Zip = 2141,
                    Country = "USA",
                }),
              new Member(
                id: 27,
                dept: Department.Accounts,
                name: "Fred L Slowik",
                grade: 4,
                salary: 28000,
                bonusRate: null,
                homePhone: "925-469-7343",
                workPhone: "818-421-8113",
                address: new Address()
                {
                    Type = AddressType.Permanent,
                    Street = "4860 Canis Heights Drive",
                    City = "Los Angeles",
                    State = "California(CA)",
                    Zip = 90071,
                    Country = "USA",
                }),
              new Member(
                id: 28,
                dept: Department.Marketing,
                name: "John E Anderson",
                grade: 4,
                salary: 27000,
                bonusRate: null,
                homePhone: "305-300-4999",
                workPhone: "561-754-9754",
                address: new Address()
                {
                    Type = AddressType.Postal,
                    Street = "881 Fincham Road",
                    City = "Palm Springs",
                    State = "California(CA)",
                    Zip = 92262,
                    Country = "USA",
                }),
              new Member(
                id: 31,
                dept: Department.Marketing,
                name: "Anthony J Wilkerson",
                grade: 6,
                salary: 18000,
                bonusRate: null,
                homePhone: "401-770-0840",
                workPhone: "401-309-1510",
                address: new Address()
                {
                    Type = AddressType.Permanent,
                    Street = "3020 Oakdale Avenue",
                    City = "Avon Park",
                    State = "Florida(FL)",
                    Zip = 33825,
                    Country = "USA",
                }),
        };
        private static void Main()
        {
            Program prg = new Program();
            prg.createXml("staff.xml");
            Console.ReadKey();
        }
        private void createXml(string fileName)
        {
            
            XmlSerializer xmlSerializer = new
           XmlSerializer(typeof(List<Member>), new XmlRootAttribute("Staff"));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
                xmlSerializer.Serialize(fs, members);
        }
    }
}
