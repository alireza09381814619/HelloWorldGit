using DataLayer_CF.Context;
using DataLayer_CF.Models;
using DataLayer_CF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_CF.Services
{

    public class PersonRepository : IPersonRepository
    {

        MyContext db;
        public PersonRepository(MyContext context)
        {
            db = context;
        }
        public void DeletePerson(Person person)
        {
            db.Entry(person).State = System.Data.Entity.EntityState.Deleted;
            // return true;

        }

        public void DeletePerson(int personId)
        {
            Person person = this.GetPersonById(personId);
            this.DeletePerson(person);

        }

        public List<Person> GetAllPerson()
        {
            return db.Persons.ToList();
        }

        public Person GetPersonById(int personId)
        {
            return db.Persons.Find(personId);
        }

        public void InsertPerson(Person person)
        {
            db.Persons.Add(person);


        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            db.Entry(person).State = System.Data.Entity.EntityState.Modified;

        }
    }
}