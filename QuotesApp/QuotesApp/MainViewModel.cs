using QuotesApp.AppServices;
using QuotesApp.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private INavigation _navigation;

        private string name;
        public ObservableCollection<QuotesModel> QuotesLists { get; set; }

        QuotesServices _quotes = new QuotesServices();




        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(nameof(Name)); } 
        }

        public MainViewModel(INavigation navigation)
        {
            
            _navigation = navigation;
            QuotesLists = new ObservableCollection<QuotesModel>();
         
            LoadData();
        }


        private async void LoadData()
        {
           
            var quotes = await _quotes.FetchQuotes();
            foreach(var quote in quotes)
            {
                QuotesLists.Add(quote);
            }
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
