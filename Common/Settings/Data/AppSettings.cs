using Common.Data;
using ControlzEx.Theming;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Windows;
using Common.Settings.Service;

namespace Common.Settings.Data
{
    public class AppSettings : ViewModelBase
    {
        public AppSettings(ISettingsService service)
        {
            _service = service;
        }

        #region PrivateField
        private readonly ISettingsService _service;
        private Theme _currentTheme;
        #endregion PrivateField

        #region PublicProperties
        public ReadOnlyObservableCollection<Theme> CollectionTheme { get; set; }

        public Theme CurrentTheme
        {
            get => _currentTheme;
            set
            {
                Set(ref _currentTheme, value);
                ThemeManager.Current.ChangeTheme(Application.Current, value);
                _service?.SaveSettings();
            }
        }

        #endregion PublicProperties
    }
}