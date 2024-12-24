using Service.Services.Classes;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Controllers
{
    public class AuthorControllers
    {
        private readonly IAuthorServices _authorServices;
        public AuthorControllers()
        {
            _authorServices=new AuthorServices();
        }
        public void GetAllByAge()
        {
            int age;
            Console.Write("Enter age:");
            age = Int32.Parse(Console.ReadLine());
            var res=_authorServices.GetAllByAge(age);
            if (res!=null)
            {
                foreach (var item in res)
                {
                    Console.WriteLine($"Name:{item.Name} Surname:{item.Surname}");
                }
            }
            else
            {
                Console.WriteLine("Bele bir yasda author yoxdur.");
            }
        }
    }
}
