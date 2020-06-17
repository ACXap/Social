using Common.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK.Data;
using VK.Repository;

namespace VK.Service
{
    public class ServiceVK : IServiceVK
    {
        public ServiceVK(IRepositoryInputVK repositoryInput)
        {
            _repositoryInput = repositoryInput;
        }

        #region PrivateField
        private readonly IRepositoryInputVK _repositoryInput;
        #endregion PrivateField

        #region PublicProperties
        public ObservableCollection<EntityPerson> CollectionPerson { get; } = new ObservableCollection<EntityPerson>();
        #endregion PublicProperties

        #region PrivateMethod
        #endregion PrivateMethod

        #region PublicMethod
        public async Task<Result<EntityPerson>> ProcessingList(string file)
        {
            Result<EntityPerson> result = new Result<EntityPerson>();

            return await Task.Run(() =>
            {
                try
                {
                    var list = _repositoryInput.GetPersons(file);

                    list.ForEach(item =>
                    {
                        CollectionPerson.Add(item);
                    });

                    result.Items = CollectionPerson;
                }
                catch (Exception ex)
                {
                    result.ErrorResult = new ErrorResult(ex.Message, EnumTypeError.ErrorFileFormat);
                }
                
                return result;

            }).ConfigureAwait(false);
        }
        #endregion PublicMethod
    }
}