using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFlixMovieLibrary
{
    //Do not change Connection Name under this class	
    public class MovieContext:DbContext
    {
        public MovieContext():base("Name=DbConnect")
        {

        }

	//Fill your code here to create DbSets MovieGeneres and Movies 
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           //Fill your code here to implement Fluent API

        }

    }
}
