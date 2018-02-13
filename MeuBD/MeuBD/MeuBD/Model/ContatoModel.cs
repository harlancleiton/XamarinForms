using SQLite;

namespace MeuBD.Model
{
    public class ContatoModel
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("{0} Telefone {1} Email {2}", Nome, Telefone, Email);
        }
    }
}