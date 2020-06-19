using System.Collections.Generic;
using vkpars.Data;

namespace vkpars.Repository
{
    public interface IRepositoryOutputVK
    {
        void CreateUser(EntityPerson user, string source);
        void CreatePhote(EntityPerson user);
        void CreateCareer(EntityPerson user);
        void CreateMilitary(EntityPerson user);
        void CreateRelationPartner(EntityPerson user);
        void CreateRelation(EntityPerson user);
        void CreateSchool(EntityPerson user);
        void CreateUniversity(EntityPerson user);

        void CreateUser(IEnumerable<EntityPerson> users, string source);
        void CreatePhote(IEnumerable<EntityPerson> users);
        void CreateCareer(IEnumerable<EntityPerson> users);
        void CreateMilitary(IEnumerable<EntityPerson> users);
        void CreateRelationPartner(IEnumerable<EntityPerson> users);
        void CreateRelation(IEnumerable<EntityPerson> users);
        void CreateSchool(IEnumerable<EntityPerson> users);
        void CreateUniversity(IEnumerable<EntityPerson> users);

        string CheckConnect();
    }
}