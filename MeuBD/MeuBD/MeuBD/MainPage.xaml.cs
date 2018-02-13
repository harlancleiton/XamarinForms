using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuBD.Database;
using MeuBD.Model;
using Xamarin.Forms;

namespace MeuBD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListaContatos.ItemsSource = new ContatoDatabase().ObterListaContatoModels();
        }

        protected void SalvarClicked(object sender, EventArgs e)
        {
            var contato = new ContatoModel {Nome = Nome.Text, Email = Email.Text, Telefone = Telefone.Text};
            new ContatoDatabase().Insert(contato);
            ListaContatos.ItemsSource = new ContatoDatabase().ObterListaContatoModels();

        }
    }
}