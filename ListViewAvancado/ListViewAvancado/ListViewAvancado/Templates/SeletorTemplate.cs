using System.Reflection;
using ListViewAvancado.Model;
using Xamarin.Forms;

namespace ListViewAvancado.Templates
{
    public class SeletorTemplate : DataTemplateSelector
    {
        public DataTemplate PessoaObrigatoriaTemplate { get; set; }
        public DataTemplate PessoaNaoObrigatoriaTemplate { get; set; }

        public SeletorTemplate()
        {
            PessoaObrigatoriaTemplate = new DataTemplate(typeof(PessoaObrigatorioViewCell));
            PessoaNaoObrigatoriaTemplate = new DataTemplate(typeof(PessoaNaoObrigatorioViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Pessoa pessoa = item as Pessoa;
            if (pessoa.IsRequired)
            {
                return PessoaObrigatoriaTemplate;
            }
            else
            {
                return PessoaNaoObrigatoriaTemplate;
            }
        }
    }
}
