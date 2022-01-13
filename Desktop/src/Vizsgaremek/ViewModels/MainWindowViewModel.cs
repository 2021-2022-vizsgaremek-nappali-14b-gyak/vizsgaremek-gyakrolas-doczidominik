﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.ViewModels.BaseClass;

namespace Vizsgaremek.ViewModels
{
    class MainWindowViewModel : ViewModelBaseClass
    {
        private string selectedSource;

        public string SelectedSource
        {
            get => selectedSource;
            set
            {
                selectedSource = value;
                OnPropertyChanged("SelectedSource");

            }
        }
    }
}
