﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QuotesApp.ViewModels
{
    
        public class BaseViewModel : INotifyPropertyChanged
        {


            public event PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
}
