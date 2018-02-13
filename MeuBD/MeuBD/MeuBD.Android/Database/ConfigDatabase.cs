using System;
using System.IO;
using MeuBD.Database;
using MeuBD.Droid.Database;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDatabase))]

namespace MeuBD.Droid.Database
{
    public class ConfigDatabase : IConfigDatabase
    {
        public string PersonalFolder { get; set; }
        public string DiretorioCompletoDB { get; set; }

        public SQLiteConnection GetConnection(string NomeDB)
        {
            PersonalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            DiretorioCompletoDB = Path.Combine(PersonalFolder, NomeDB);
            return new SQLiteConnection(DiretorioCompletoDB);
        }
    }
}