using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    public abstract class Company
    {
        public string CompanyName { get; set; }
        public Company()
        {

        }

        protected Company(string companyName)
        {
            CompanyName = companyName;
        }

        public void CompanyInfo()
        {
            Console.WriteLine("Company Name: " + this.CompanyName);
        }
        public abstract void BatchRule();
    }
}
