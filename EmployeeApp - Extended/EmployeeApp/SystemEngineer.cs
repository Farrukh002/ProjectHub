using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class SystemEngineer : CasualWork, ISystemEngineer
    {
        public string WorkPlace { get; set; }
        public SystemEngineer(int employeeId, string firstName, string lastName,
        string email, string phone, Gender gender, Address address, double weeklyPayment)
        : base(employeeId, firstName, lastName, email, phone, gender, address, weeklyPayment)
        { }

        public override string getJobName()
        {
            return "System Engineer";
        }
        public void doSystemEngineering()
        {
            Console.WriteLine("Doing System Engineering...");
        }
    }
}
