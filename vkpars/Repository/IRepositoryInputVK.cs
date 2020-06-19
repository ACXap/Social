using System.Collections.Generic;
using vkpars.Data;

namespace vkpars.Repository
{
    public interface IRepositoryInputVK
    {
        List<EntityPerson> GetPersons(string fileName);
    }
}