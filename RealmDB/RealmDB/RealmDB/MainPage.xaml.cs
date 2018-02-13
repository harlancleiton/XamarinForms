using System.Linq;
using RealmDB.Database;
using RealmDB.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace RealmDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}