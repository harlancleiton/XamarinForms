namespace CriarArquivo.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new CriarArquivo.App());
        }
    }
}
