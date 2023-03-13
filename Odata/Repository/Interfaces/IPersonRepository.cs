using Odata.Models;

namespace Odata.Repository.Interfaces;
public interface IPersonRepository {
    public List<PersonModel> getPersons(int take);
}

