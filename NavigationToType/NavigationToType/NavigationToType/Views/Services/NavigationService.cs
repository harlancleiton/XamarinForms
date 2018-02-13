using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationToType.ViewModels.Services;
using Xamarin.Forms;

namespace NavigationToType.Views.Services
{
    class NavigationService : INavigationService
    {
        public void NavigateTo(Type type)
        {
            Page page = (Page) Activator.CreateInstance(type);
            Application.Current.MainPage.Navigation.PushModalAsync(page);
        }
    }
}