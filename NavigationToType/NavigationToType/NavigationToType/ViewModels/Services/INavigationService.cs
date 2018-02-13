using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationToType.ViewModels.Services
{
    interface INavigationService
    {
        void NavigateTo(Type type);
    }
}