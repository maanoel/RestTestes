using System.Collections.Generic;
using TESTESRest.Services;


namespace TESTESRest.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        IEnumerable<Person> FindAll();
        Person FindById(int id);
        Person Update(Person person);
        void Delete(int id);
    }
}
