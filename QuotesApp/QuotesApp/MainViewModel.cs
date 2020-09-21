using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuotesApp
{
   public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }


        private string name;

        

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(nameof(Name)); } 
        }

        public MainViewModel()
        {
            LoginCommand = new Command(login);
        }


        private void login()
        {
          
            App.Current.MainPage.DisplayAlert("Hello", Name, "ok");
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
