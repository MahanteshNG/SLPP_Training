using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCollectionObjectsEx2
{
    public class EmployeeBL
    {
        public static List<EmployeeDL> DisplayAllEmployees(List<EmployeeDL> li)
        {
            return li;
        }

        public static List<EmployeeDL> DisplayEmployeesByDepartment
            (List<EmployeeDL> li, string searchDeptartment)
        {
            return li.Where(x => x.DepartmentName.
              Equals(searchDeptartment, StringComparison.InvariantCultureIgnoreCase)).ToList();          
        }

        public static EmployeeDL DisplayEmployeeById(List<EmployeeDL> li, int searchId)
        {
            return li.Where(x => x.EmployeeId == searchId).FirstOrDefault();
        }
    }
}
