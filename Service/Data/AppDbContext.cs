using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public static class AppDbContext
    {
       
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author{Id=1,Name="Nurana",Surname="Ismayilzada",Age=24},
                new Author{Id=2,Name="Nunu",Surname="Ismayilzada",Age=17},
                new Author{Id=3,Name="Nurka",Surname="Ismayilzada",Age=14},
                new Author{Id=4,Name="Nurane",Surname="Ismayilzada",Age=28},
                new Author{Id=5,Name="Nurus",Surname="Ismayilzada",Age=25},
            };
        }

        public static List<Employee> Employees() {
            return new List<Employee>()
            {
                new Employee{Id=1,Name="Nurana",Surname="Ismayilzada",Salary=2500,Birthday=new DateTime(2002,10,19)},
                new Employee{Id=2,Name="Ismayil",Surname="Ismayilov",Salary=300,Birthday=new DateTime(2006,8,5)},
                new Employee{Id=3,Name="Alisa",Surname="Ismayilova",Salary=2000,Birthday=new DateTime(2004,10,10)},
                new Employee{Id=4,Name="Ruzgar",Surname="Ismayilzada",Salary=750,Birthday=new DateTime(2005,10,19)},
                new Employee{Id=5,Name="Nurana",Surname="Ismayilzada",Salary=500,Birthday=new DateTime(2001,10,19)},

            };
        }

    }
}
