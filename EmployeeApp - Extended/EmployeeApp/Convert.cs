using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Helper
{
    internal class Convert
    {
        private static string[] domainName = { "hotmail", "gmail", "yahoo",
                "freemail", "company" },extension = { "com", "net", "eu", "hu", "uk" };
        public static string toEmailFormat(string firstName, string lastName)
        {
            return
           $"{firstName.ToLower()}.{lastName.ToLower()}@{RandomEmployee.generateElementOf(domainName)}.{RandomEmployee.generateElementOf(extension)}";
        }
        public static string toHungarianPhoneFormatOf(string phoneNumber)
        {
            return $"{phoneNumber.Substring(0, 2)}/{phoneNumber.Substring(2, 2)} { phoneNumber.Substring(4, 3)}-{ phoneNumber.Substring(7, 4)}";
        }

    }
}
