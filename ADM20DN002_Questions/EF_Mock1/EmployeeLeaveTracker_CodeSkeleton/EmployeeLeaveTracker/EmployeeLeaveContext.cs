using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmployeeLeaveTracker
{
    public class EmployeeLeaveContext:DbContext
    {
	//Do NOT change the context name EmployeeLeaveContext or DbConnect name
        public EmployeeLeaveContext():base("Name=DbConnect")
        {

        }
	
	//Implement property for 'Leaves' with required 'DbSet' declaration 
	//use public accessor and virtual keyword while declaring DbSet
        
    }
}
