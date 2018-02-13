using SQLite;

namespace MeuBD.Database
{
    public interface IConfigDatabase
    {
        string PersonalFolder { get; set; }
        string DiretorioCompletoDB { get; set; }
        SQLiteConnection GetConnection(string NomeDB);
    }
}
