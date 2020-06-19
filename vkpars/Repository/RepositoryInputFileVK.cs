using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using vkpars.Data;
using vkpars.Service;

namespace vkpars.Repository
{
    public class RepositoryInputFileVK : IRepositoryInputVK
    {
        public RepositoryInputFileVK(ILogger logger)
        {
            _logger = logger;
        }

        #region PrivateField
        private readonly ILogger _logger;
        #endregion PrivateField

        #region PublicMethod

        public List<EntityPerson> GetPersons(string fileName)
        {
            List<EntityPerson> list = new List<EntityPerson>();
           
            var str = File.ReadLines(fileName);
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
                    Console.WriteLine($"Ошибка разбора данных: {ex.Message} В файле {Path.Combine(Directory.GetCurrentDirectory(), "log.txt")} подробности");
                }
            }

            return list;
        }
        #endregion PublicMethod
    }
}