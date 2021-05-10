using Autofac.Core.Bootstrapper;
using Autofac.Core.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Autofac
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = Resolver.Resolve<MainView>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
