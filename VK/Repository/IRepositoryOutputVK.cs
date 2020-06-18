using VK.Data;

namespace VK.Repository
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
    }
}