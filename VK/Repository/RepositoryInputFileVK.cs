using Common.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VK.Data;

namespace VK.Repository
{
    public class RepositoryInputFileVK : IRepositoryInputVK
    {
        public RepositoryInputFileVK(ILoggerService logger)
        {
            _logger = logger;
        }

        #region PrivateField
        private readonly ILoggerService _logger;
        #endregion PrivateField

        #region PublicProperties
        #endregion PublicProperties

        #region PrivateMethod
        #endregion PrivateMethod

        #region PublicMethod
        public EntityPerson GetPerson()
        {
            throw new NotImplementedException();
        }

        public List<EntityPerson> GetPersons(string fileName)
        {
            List<EntityPerson> list = new List<EntityPerson>();
           
            var str = File.ReadLines(fileName).Skip(1);
            foreach(var item in str)
            {
                try
                {
                    var obj = JsonConvert.DeserializeObject<Response>(item);

                    list.Add(obj.CollectionPerson[0]);
                }
                catch(Exception ex)
                {
                    _logger?.AddLog(ex.Message);
                    _logger?.AddLog(item);
                }
            }

            return list;
        }
        #endregion PublicMethod
    }
}