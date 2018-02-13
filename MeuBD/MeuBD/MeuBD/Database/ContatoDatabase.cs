using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuBD.Model;
using SQLite;
using Xamarin.Forms;

namespace MeuBD.Database
{
    public class ContatoDatabase : IDisposable
    {
        private SQLiteConnection _connection;

        public ContatoDatabase()
        {
            _connection = DependencyService.Get<IConfigDatabase>().GetConnection("MeuDB.db3");
            _connection.CreateTable<ContatoModel>();
        }

        public void Insert(ContatoModel contatoModel)
        {
            _connection.Insert(contatoModel);
        }

        public void Update(ContatoModel contatoModel)
        {
            _connection.Update(contatoModel);
        }

        public void Delete(ContatoModel contatoModel)
        {
            _connection.Delete(contatoModel);
        }

        public ContatoModel ObterPorIdContatoModel(int id)
        {
            return _connection.Table<ContatoModel>().FirstOrDefault(contato => contato.Id == id);
        }

        public List<ContatoModel> ObterListaContatoModels()
        {
            return _connection.Table<ContatoModel>().OrderBy(contato => contato.Nome).ToList();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}