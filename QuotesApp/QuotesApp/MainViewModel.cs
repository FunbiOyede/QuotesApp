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
   public class MainViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        private INavigation _navigation;

        private string name;
        private bool loader;
        public ObservableCollection<QuotesModel> QuotesLists { get; set; }

        QuotesServices _quotes = new QuotesServices();




        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(nameof(Name)); } 
        }


        public bool Loader {
            get { return loader; }
            set { loader = value; RaisePropertyChanged(nameof(Loader)); }
        }
        public MainViewModel(INavigation navigation)
        {

            //_navigation = navigation;
            QuotesLists = new ObservableCollection<QuotesModel>();
            Loader = true;
            LoadData();
        }


        private async void LoadData()
        {
           
            var quotes = await _quotes.FetchQuotes();
            foreach(var quote in quotes)
            {
                QuotesLists.Add(quote);
            }

            Loader = false;
        }


      
    }
}
