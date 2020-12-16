using QuotesApp.AppServices;
using QuotesApp.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuotesApp.ViewModels
{
   public class QuotesViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        private INavigation _navigation;
        private IQuotesService _quotesService;

        private string name;
        private bool loader;
        public ObservableCollection<QuotesModel> QuotesLists { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(nameof(Name)); }
        }


        public bool Loader
        {
            get { return loader; }
            set { loader = value; RaisePropertyChanged(nameof(Loader)); }
        }
        public QuotesViewModel(IQuotesService quotesService)
        {

            //_navigation = navigation;
            QuotesLists = new ObservableCollection<QuotesModel>();
            _quotesService = quotesService;
            Loader = true;
            LoadData();
        }


        private async void LoadData()
        {

            var quotes = await _quotesService.FetchQuotes();
            foreach (var quote in quotes)
            {
                QuotesLists.Add(quote);
            }

            Loader = false;
        }
    }
}
