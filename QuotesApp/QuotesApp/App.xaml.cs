using CommonServiceLocator;
using QuotesApp.AppServices;
using Unity;
using Xamarin.Forms;

namespace QuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var unityContainer = new UnityContainer();
            //unityContainer.RegisterType<IQuotesService, QuotesServices>();
            //ServiceLocator.SetLocatorProvider(() => new ServiceLocator(unityContainer));

            MainPage = new NavigationPage(new MainPage());
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
