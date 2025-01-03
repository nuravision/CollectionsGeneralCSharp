﻿using Domain.Models;
using Service.Data;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Classes
{
    public class AuthorServices : IAuthorServices
    {
        public List<Author> GetAllByAge(int age)
        {
            return AppDbContext.Authors().Where(m => m.Age > age).ToList();
        }
    }
}
