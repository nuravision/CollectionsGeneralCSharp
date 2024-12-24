using Service.Services.Classes;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Controllers
{
    public class EmployeeControllers
    {
        private readonly IEmployeServices _employeServices;
        public EmployeeControllers()
        {
            _employeServices=new EmployeServices();
        }
        public void GetBySalaryCount()
        {
            decimal salary;
            Console.WriteLine("Enter salary:");
            salary = decimal.Parse(Console.ReadLine());
            var res = _employeServices.GetBySalary(salary);
            int count = 0;
            if (res != null)
            {
                foreach (var item in res) { 
                    count++;    
                }
            }
            Console.WriteLine($"Say:{count}");
        }
        public void GetBySalaryAndDate()
        {
            decimal salary;
            Console.WriteLine("Enter salary:");
            salary = decimal.Parse(Console.ReadLine());
            var res = _employeServices.GetBySalaryAndDate(salary, new DateTime(2003, 01, 19), new DateTime(2008, 11, 25));
            if (res!=null)
            {
                foreach (var item in res)
                {
                    Console.WriteLine($"Name:{item.Name} Surname:{item.Surname}");
                }
            }

        }
    }
}
