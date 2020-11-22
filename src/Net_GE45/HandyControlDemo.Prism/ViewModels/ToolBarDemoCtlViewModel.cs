﻿using HandyControlDemo.Properties.Langs;
using HandyControlDemo.Tools.Converter;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace HandyControlDemo.ViewModels
{
    public class ToolBarDemoCtlViewModel : BindableBase
    {
        private ObservableCollection<string> _DataList;
        public ObservableCollection<string> DataList
        {
            get { return _DataList; }
            set { SetProperty(ref _DataList, value); }
        }

        public ToolBarDemoCtlViewModel()
        {
            DataList = new ObservableCollection<string>(GetToolBarDemoDataList());
        }

        internal List<string> GetToolBarDemoDataList()
        {
            var converter = new StringRepeatConverter();
            var list = new List<string>();
            for (var i = 1; i <= 9; i++)
            {
                list.Add($"{converter.Convert(Lang.Text, null, i, CultureInfo.CurrentCulture)}{i}");
            }

            return list;
        }
    }
}