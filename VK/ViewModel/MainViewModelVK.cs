using Common;
using Common.Service;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using VK.Data;
using VK.Service;

namespace VK.ViewModel
{
    public class MainViewModelVK : FoundViewModelBase
    {
        public MainViewModelVK(IServiceVK service)
        {
            _service = service;

            FoundHeader = new Common.Data.FoundHeader()
            {
                CommandFound = new RelayCommand(() => OpenFile()),
                FoundFast = false,
                Header = "Обработка списков",
                Watermark = "Выбрать файл с данными для обработки"
            };
        }

        #region PrivateField
        private readonly IServiceVK _service;
        private readonly ServiceFile<TypeDataVK> _serviceFile = new ServiceFile<TypeDataVK>();
        private TypeDataVK _typeData;

        private ObservableCollection<EntityPerson> _collectionPerson;

        private RelayCommand _commandStart;
        #endregion PrivateField

        #region PublicProperties
        public ObservableCollection<EntityPerson> CollectionPerson
        {
            get => _collectionPerson;
            set => Set(ref _collectionPerson, value);
        }
        public TypeDataVK TypeData
        {
            get => _typeData;
            set => Set(ref _typeData, value);
        }
        #endregion PublicProperties

        #region Command
        public RelayCommand CommandStart =>
        _commandStart ?? (_commandStart = new RelayCommand(
           async  () =>
            {
                StartProcess();

                var result = await _service.ProcessingList(FoundHeader.FoundText);

                if (result != null)
                {
                    if (result.ErrorResult == null)
                    {
                        CollectionPerson = new ObservableCollection<EntityPerson>(result.Items);
                    }
                }

                StopProcess(result?.ErrorResult);

            }, () => _typeData != null && _typeData.Code != 0));
        #endregion Command

        #region PrivateMethod
        private async void OpenFile()
        {
            var file = _serviceFile.GetFile();

            if (string.IsNullOrEmpty(file) == false)
            {
                FoundHeader.FoundText = file;
                TypeData = await _serviceFile.GetTypeData(file).ConfigureAwait(false);
            }
        }
        #endregion PrivateMethod
    }
}