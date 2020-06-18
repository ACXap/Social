using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Data;

namespace VK.Repository
{
    public interface IRepositoryOutputVK
    {
        void CreateUser(EntityPerson user, string source);
    }
}