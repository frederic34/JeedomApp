﻿using Jeedom.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace JeedomApp.Converters
{
    internal class EqLogicCmdInfoByTypeConverter : IValueConverter
    {
        #region Public Methods

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var cmds = (ObservableCollection<Command>)value;
            var searchType = parameter.ToString();
            var searchcmd = cmds.Where(c => c.Display.generic_type == searchType).FirstOrDefault();

            if (searchcmd != null)
            {
                return searchcmd.Value;
            }
            else
            {
                return "N/A";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}