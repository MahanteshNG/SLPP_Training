using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmployeeLeaveTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            LeaveModel leaveModel = new LeaveModel();
            EmployeeLeaveRepository employeeLeaveRepository = new EmployeeLeaveRepository();
            Console.WriteLine("Welcome to HRM Leave App.\nPress Yes to continue\n" +
                "Any other key to terminate application");
            string loopInput = Console.ReadLine();

            while (loopInput.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("\nChoose your User Type:\nPress 1 for Employee" +
                    "\nPress 2 for Admin\nPress any other number to terminate the application");
                int userType = Convert.ToInt32(Console.ReadLine());

                switch (userType)
                {
                    case 1:
                        Console.WriteLine("\nWelcome Employee");
                        Console.WriteLine("Press 1 to Apply for Leaves" +
                            "\nPress 2 to View your Leaves\nPress any other number to terminate application");
                        int employeeChoice = Convert.ToInt32(Console.ReadLine());

                        switch (employeeChoice)
                        {
                            case 1:
                                try
                                {
                                    Console.WriteLine("\nEnter Employee Id:");
                                    string empId = Console.ReadLine();
                                    bool result = program.EmployeeIdCheck(empId);
                                    if(result)
                                    {
                                        leaveModel.EmployeeId = empId;
                                    }
                                    else
                                    {
                                        throw new FormatException("Employee Id not in correct format..Start the entry again");
                                    }
                                    Console.WriteLine("Enter Employee Name:");
                                    leaveModel.EmployeeName = Console.ReadLine();
                                    Console.WriteLine("Enter the Start Date(in yyyy/MM/dd format):");
                                    DateTime fromDate = DateTime.ParseExact(Console.ReadLine(),
                                        "yyyy/MM/dd", null);
                                    Console.WriteLine("Enter the End Date(in yyyy/MM/dd format):");
                                    DateTime toDate = DateTime.ParseExact(Console.ReadLine(),
                                        "yyyy/MM/dd", null);
                                    bool dateResult = program.DateChecker(fromDate, toDate);                                    
                                    if(dateResult)
                                    {
                                        leaveModel.FromDate = fromDate;
                                        leaveModel.ToDate = toDate;
                                    }
                                    else
                                    {
                                        throw new Exception("Either end date is less than Start Date or the Employee has already applied leave on the given dates..Start your entry again");
                                    }
                                    Console.WriteLine("Enter Leave Type(Casual Leave/Sick Leave):");
                                    leaveModel.LeaveType = Console.ReadLine();
                                    LeaveModel newLeave = employeeLeaveRepository.ApplyForLeave(leaveModel);
                                    Console.WriteLine("Leave Applied Successfully");
                                }
                                catch (FormatException empIdFormatException)
                                {
                                    Console.WriteLine("Leave Application Failed. Check Your Entry");
                                    Console.WriteLine(empIdFormatException.Message);
                                }
                                catch (Exception dateException)
                                {
                                    Console.WriteLine("Leave Application Failed. Check Your Entry");
                                    Console.WriteLine(dateException.Message);
                                }
                                
                                break;

                            case 2:
                                Console.WriteLine("\nEnter your Employee ID to check your leaves:");
                                string searchEmployeeId = Console.ReadLine();
                                List<LeaveModel> employeeLeave = employeeLeaveRepository.DisplayEmployeeLeaveInfo(searchEmployeeId);
                                if (employeeLeave.Count > 0)
                                {
                                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}",
                                        "Employee Id", "Employee Name", "From Date", "To Date",
                                        "Leave Type");
                                    foreach (var leaveData in employeeLeave)
                                    {
                                        Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}",
                                            leaveData.EmployeeId, leaveData.EmployeeName,
                             leaveData.FromDate.ToString("yyyy/MM/dd"), leaveData.ToDate.ToString("yyyy/MM/dd"),
                                            leaveData.LeaveType);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No Leave information found for your id");
                                }
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("\nWelcome Admin");

                        List<LeaveModel> allLeaves = employeeLeaveRepository.DisplayEmployeeLeavesForAdmin();
                        if (allLeaves.Count > 0)
                        {
                            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}",
                                "Leave Id", "Employee Id", "Employee Name", "From Date", "To Date",
                                "Leave Type");
                            foreach (var leaveData in allLeaves)
                            {
                                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}",
                                    leaveData.LeaveNumber, leaveData.EmployeeId, leaveData.EmployeeName,
                                    leaveData.FromDate.ToString("yyyy/MM/dd"), leaveData.ToDate.ToString("yyyy/MM/dd"),
                                    leaveData.LeaveType);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No employee has applied for leave");
                        }
                        break;
                }
                       
                
                Console.WriteLine("Press Yes to continue using the App..Any other key to terminate");
                loopInput = Console.ReadLine();
            }
            Console.WriteLine("Thanks for using the HRM Leave Application. Have a nice day");
        }
	
	/* Use this method to check if the Empoyee Id format is correct. A valid Id is in the below
	format: First 3 data of Id should be letters(in capital only) and next 4 data should be numbers
	between 0 to 9. For example: EMP1001 is valid, emp1001 is invalid, em12345 is invalid. Return
        true if Id is valid or false if Id is invalid */
        public bool EmployeeIdCheck(string empId)
        {
            //Fill your code here
            
        }
        
        /* Use this method to check if the end date is greater or same as start date which is valid
	entry. Return true if end date >= start date; return false if end date < start date */
        public bool DateChecker(DateTime startDate,DateTime endDate)
        {
            //Fill your code here
            
        }

       
    }
}
