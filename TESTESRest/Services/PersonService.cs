using System;
using System.Collections.Generic;
using TESTESRest.Model;

namespace TESTESRest.Services
{
    public class PersonService : IPersonService
    {
        private MySqlContext _context;

        public PersonService(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception )
            {
                throw;
            }

            return person;
        }

        public void Delete(int id)
        {
            _context.Remove(id);
        }

        public IEnumerable<Person> FindAll()
        {
            return _context.People;
        }

        public Person FindById(int id)
        {
            return _context.People.Find(id);
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return new Person();

            var result = _context.People.Find(person.Id);

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
            return person;
        }

        private bool Exists(int id)
        {
            var person = _context.People.Find(id);
            return person != null;
        }
    }
}