using System.Collections.Generic;
using TESTESRest.Repository;

namespace TESTESRest.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public IEnumerable<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(int id)
        {
            return _personRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }
    }
}
