using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using RealmDB.Database;
using RealmDB.Model;
using Xamarin.Forms;

namespace RealmDB
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ItemModel> ItemModels { get; set; }
        public int Quantidade { get; set; }
        public ItemModel ItemModelAtual { get; set; }
        public ICommand SalvarItemCommand { get; set; }

        public MainViewModel()
        {
            ItemModelAtual = new ItemModel();
            SalvarItemCommand = new Command(SalvarItem);
            ItemModels = new ObservableCollection<ItemModel>(new ItemDatabase().GetItens());
        }

        private void SalvarItem()
        {
            new ItemDatabase().SalvarItem(ItemModelAtual);
            ItemModels.Add(ItemModelAtual);
            ItemModelAtual = new ItemModel();
            OnPropertyChanged("ItemModelAtual");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}