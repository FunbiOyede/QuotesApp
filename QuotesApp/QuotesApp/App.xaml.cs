using CommonServiceLocator;
using QuotesApp.AppServices;
using QuotesApp.Views;
using Unity;
using Unity.ServiceLocation;

using Xamarin.Forms;

namespace QuotesApp
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

           var container = new UnityContainer();
            container.RegisterType<IQuotesService, QuotesServices>();
            var unityServiceLocator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);
            MainPage = new NavigationPage(new QuotesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
