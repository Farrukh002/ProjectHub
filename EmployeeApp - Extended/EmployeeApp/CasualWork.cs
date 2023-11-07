using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public abstract class CasualWork : Employee
    {
        public double WeeklyPayment { get; set; }
        public CasualWork(int employeeID, string firstName, string lastName, string email,
        string phone, Gender gender, Address address, double weeklyPayment)
        : base(employeeID, firstName, lastName, email, phone, gender, address)
        {
            WeeklyPayment = weeklyPayment;
        }

        public override double getMonthlySalary()
        {
            return WeeklyPayment * 4;
        }

    }
}
