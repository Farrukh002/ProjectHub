using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StaffApp
{
    public enum Department { Marketing, Sales, Accounts};
    public class Member
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public Department Dept { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Salary { get; set; }
        public double? BonusRate { get; set; }
        [XmlAttribute]
        public string HomePhone { get; set; }
        [XmlAttribute]
        public string WorkPhone { get; set; }
        [XmlElement]
        public Address Address { get; set; }

        public Member(int id, Department dept, string name, int grade, int salary, double? bonusRate,
            string homePhone, string workPhone, Address address)
        {
            this.Id = id;
            this.Dept = dept;
            this.Name = name;
            this.Grade = grade;
            this.Salary = salary;
            this.BonusRate = bonusRate;
            this.HomePhone = homePhone;
            this.WorkPhone = workPhone;
            this.Address = address;
            
        }
        public Member()
        {

        }
    }
}
