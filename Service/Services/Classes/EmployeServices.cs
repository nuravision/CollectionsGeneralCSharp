using Domain.Models;
using Service.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Classes
{
    public class EmployeServices : IEmployeServices
    {
        public List<Employee> GetBySalary(decimal salary)
        {
            return AppDbContext.Employees().Where(m=>m.Salary>salary).ToList();
        }

        public List<Employee> GetBySalaryAndDate(decimal salary, DateTime date1, DateTime date2)
        {
            return AppDbContext.Employees().Where(m=>m.Salary>salary && m.Birthday>date1 && m.Birthday < date2).ToList();
        }
    }
}
