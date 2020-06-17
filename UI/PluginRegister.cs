#region using
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using UI.Data;
using VK.Repository;
using VK.Service;
using VK.ViewModel;
using VK.Views;
#endregion using

namespace UI
{
    public class PluginRegister
    {
        public static void Register()
        {
            SimpleIoc.Default.Register<IRepositoryInputVK, RepositoryInputFileVK>();
            SimpleIoc.Default.Register<IServiceVK, ServiceVK>();
            SimpleIoc.Default.Register<MainViewModelVK>();
        }

        public List<EntityPlugin> GetPlugin()
        {
            var list = new List<EntityPlugin>()
            {
                new EntityPlugin()
                {
                    Id = 1,
                    Icon = new PackIconFontAwesome() {Kind =PackIconFontAwesomeKind.VkBrands },
                    Label = "VK",
                    ToolTip = "Обработка файлов VK",
                    Tag = new MainViewVK()
                }
            };

            return list;
        }

        public List<EntityPlugin> GetMenu()
        {
            var list = new List<EntityPlugin>()
            {
                 new EntityPlugin()
                {
                    Id = 1,
                    Icon = new PackIconFontAwesome() {Kind =PackIconFontAwesomeKind.VkBrands },
                    Label = "VK",
                    ToolTip = "Обработка файлов VK",
                },
            };

            return list;
        }

        public static ViewModelBase MainViewModelVK => ServiceLocator.Current.GetInstance<MainViewModelVK>();
    }
}