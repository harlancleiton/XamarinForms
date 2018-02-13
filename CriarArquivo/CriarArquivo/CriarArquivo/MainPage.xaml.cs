using System;
using PCLStorage;
using Xamarin.Forms;

namespace CriarArquivo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnGravarArquivo_OnClicked(object sender, EventArgs e)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("MyFolder", CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync("MyFile.txt", CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync(ConteudoArquivo.Text);
        }

        private async void BtnLerArquivo_OnClicked(object sender, EventArgs e)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("MyFolder", CreationCollisionOption.OpenIfExists);
            IFile file = await folder.GetFileAsync("MyFile.txt");
            LblArquivo.Text = await file.ReadAllTextAsync();
        }
    }
}