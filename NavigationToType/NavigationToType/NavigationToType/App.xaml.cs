using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NavigationToType.ViewModels.Services;
using NavigationToType.Views;
using NavigationToType.Views.Services;
using Xamarin.Forms;

namespace NavigationToType
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<INavigationService, NavigationService>();

            //MainPage = new NavigationPage(new LoginView());
            MainPage = new LoginView();
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
