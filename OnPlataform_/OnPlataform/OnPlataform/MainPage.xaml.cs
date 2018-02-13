using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OnPlataform
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    ITeste teste = DependencyService.Get<ITeste>();
            teste.FunTeste();
		}
	}
}
