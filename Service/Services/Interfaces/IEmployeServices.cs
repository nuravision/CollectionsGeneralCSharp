using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IEmployeServices
    {
        List<Employee> GetBySalary(decimal salary);
        List<Employee> GetBySalaryAndDate(decimal salary,DateTime date1,DateTime date2);


    }
}
