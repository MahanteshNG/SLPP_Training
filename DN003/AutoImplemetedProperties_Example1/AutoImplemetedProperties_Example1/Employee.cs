using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Create a class called Employee with auto-implemeted properties like Id,Name. Pass data to
 * Employee class via the properties or extract data using properties */

    /* Auto implemeted properties are generated in the class which does not contain class members */
namespace AutoImplemetedProperties_Example1
{
    public class Employee
    {
        //Auto Implemented Properties
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
