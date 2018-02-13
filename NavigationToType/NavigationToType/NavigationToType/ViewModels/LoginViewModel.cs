using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NavigationToType.ViewModels.Services;
using NavigationToType.Views;
using Xamarin.Forms;

namespace NavigationToType.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        #region Properties
        public ICommand LoginCommand { get; set; }
        private readonly INavigationService _navigationService;
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            /*
             * É assim que se trabalha na ViewModel, eu sei que precisa enviar uma mensagem, como vai ser enviada não me importa
             * Me dá uma instancia da classe que implementa essa interface
             */
            //_messageService = DependencyService.Get<IMessageService>();
            _navigationService = DependencyService.Get<INavigationService>();
        }

        private void Login()
        {
            _navigationService.NavigateTo(typeof(RegistroView));
        }
    }
}
