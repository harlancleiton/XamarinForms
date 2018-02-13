namespace RealmDB.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new RealmDB.App());
        }
    }
}
