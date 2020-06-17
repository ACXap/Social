using System.Collections.Generic;
using VK.Data;

namespace VK.Repository
{
    public interface IRepositoryInputVK
    {
        EntityPerson GetPerson();
        List<EntityPerson> GetPersons(string fileName);
    }
}