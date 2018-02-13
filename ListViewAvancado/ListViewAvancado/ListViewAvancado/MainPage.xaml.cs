using System.Collections.Generic;
using ListViewAvancado.Model;
using Xamarin.Forms;

namespace ListViewAvancado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Lista.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO", "Presidente da Empresa")
                {
                    new Pessoa() {Nome = "Felix", IsRequired = true, RankEficiencia = 8}
                },
                new Grupo("Planejamento", "Plan.", "Setor de Planejamento e Orçamentos de Obras")
                {
                    new Pessoa() {Nome = "Janielson", IsRequired = false, RankEficiencia = 6},
                    new Pessoa() {Nome = "Jackson", IsRequired = true, RankEficiencia = 8},
                    new Pessoa() {Nome = "Carlos", IsRequired = true, RankEficiencia = 9}
                },
                new Grupo("Tecnologia da Informação", "TI", "Setor de Tecnologia da Informação")
                {
                    new Pessoa() {Nome = "João", IsRequired = false, RankEficiencia = 9},
                    new Pessoa() {Nome = "Emmanuel", IsRequired = true, RankEficiencia = 8},
                    new Pessoa() {Nome = "Harlan", IsRequired = true, RankEficiencia = 8}
                },
                new Grupo("Colaboradores", "Colab.", "Demais colaboradores")
                {
                    new Pessoa() {Nome = "José", IsRequired = false},
                    new Pessoa() {Nome = "Eduardo", IsRequired = false},
                    new Pessoa() {Nome = "Souza", IsRequired = false},
                    new Pessoa() {Nome = "Carlos", IsRequired = false},
                    new Pessoa() {Nome = "Souza", IsRequired = false},
                    new Pessoa() {Nome = "Edson", IsRequired = true, RankEficiencia = 8},
                    new Pessoa() {Nome = "Felipe", IsRequired = false},
                    new Pessoa() {Nome = "Silvana", IsRequired = false},
                    new Pessoa() {Nome = "Edilson", IsRequired = false},
                    new Pessoa() {Nome = "Ialana", IsRequired = false},
                    new Pessoa() {Nome = "Joelma", IsRequired = false},
                    new Pessoa() {Nome = "Jessica", IsRequired = false},
                    new Pessoa() {Nome = "Cassio", IsRequired = false}
                }
            };
        }
    }
}