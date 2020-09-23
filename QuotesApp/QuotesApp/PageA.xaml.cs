using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageA : ContentPage
    {
        public PageA(string name)
        {
            InitializeComponent();
            BindingContext = new PageAViewModel(name);
        }
    }
}