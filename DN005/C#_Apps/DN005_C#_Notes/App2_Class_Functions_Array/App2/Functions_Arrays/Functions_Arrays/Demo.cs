using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Arrays
{
    public class Demo
    {
        /* Instance Non Return Method */
        public void CompanyName(string companyName)
        {
            Console.WriteLine("Company Name: " + companyName);
        }
        /* Instance Return Method */
        public string CompanyHO(string headOffice)
        {
            return headOffice;
        }

        //class members
        private static string _employeeName;
        private static int _employeeId;
        private static double _monthlySalary;

        public static string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public static int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public static double MonthlySalary { get => _monthlySalary; set => _monthlySalary = value; }

        //properties

        /* Non Return type static Method */
        public static void EmployeeDisplay()
        {
            Console.WriteLine("Employee Id: {0}\nEmployee Name: {1}\n Monthly Salary: {2}",
                EmployeeId, EmployeeName, MonthlySalary);
        }

        /* Return Type Static Method */
        public static double AnnualSalary()
        {
            return MonthlySalary * 12;
        }

        public static double TotalRevenue(double[] Revenue,int size)
        {
            double totalRevenue = 0;
            for(int i=0;i<size;i++)
            {
                totalRevenue = totalRevenue + Revenue[i];
            }
            return totalRevenue;
        }
    }
}
