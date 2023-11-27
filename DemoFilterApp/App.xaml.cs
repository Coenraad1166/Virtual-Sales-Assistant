using DemoFilterApp.MVVM.Views;

namespace DemoFilterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SelectType());
        }
    }
}