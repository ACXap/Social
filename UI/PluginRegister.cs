#region using
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using UI.Data;
#endregion using

namespace UI
{
    public class PluginRegister
    {
        public static void Register()
        {
            
        }

        public List<EntityPlugin> GetPlugin()
        {
            var list = new List<EntityPlugin>()
            {
                
            };

            return list;
        }

        public List<EntityPlugin> GetMenu()
        {
            var list = new List<EntityPlugin>()
            {
               
            };

            return list;
        }
    }
}