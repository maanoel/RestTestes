using System.Collections.Generic;

namespace TESTESRest.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(int id);

        Person Update(Person person);

        IEnumerable<Person> FindAll();
        void Delete(int id);
    }
}
