using Common.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Data;

namespace VK.Service
{
    public interface IServiceVK
    {
        ObservableCollection<EntityPerson> CollectionPerson { get; }

        Task<Result<EntityPerson>> ProcessingList(string file);
    }
}