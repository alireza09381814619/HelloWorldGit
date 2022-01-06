using DataLayer_CF.Context;
using DataLayer_CF.Models;
using DataLayer_CF.Repositories;
using DataLayer_CF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext db = new MyContext(); 
            IPersonRepository personRepository = new PersonRepository(db);
            personRepository.InsertPerson(new Person() 
            { 
                Name = "Ali" , 
                Family = "Alizade" , 
                WebSite = "TopLearn.com"
            });
            personRepository.Save();
            db.Dispose(); 

        }
    }
}
