using System;
using System.IO;
using MeuBD.Database;
using Xamarin.Forms;
using MeuBD.iOS.Database;
using SQLite;

[assembly: Dependency(typeof(ConfigDatabase))]

namespace MeuBD.iOS.Database
{
    public class ConfigDatabase : IConfigDatabase
    {
        public string PersonalFolder { get; set; }
        public string DiretorioCompletoDB { get; set; }

        public SQLiteConnection GetConnection(string NomeDB)
        {
            PersonalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string LibDiretorio = Path.Combine(PersonalFolder, "..", "Library");
            DiretorioCompletoDB = Path.Combine(LibDiretorio, NomeDB);
            return new SQLiteConnection(DiretorioCompletoDB);
        }
    }
}