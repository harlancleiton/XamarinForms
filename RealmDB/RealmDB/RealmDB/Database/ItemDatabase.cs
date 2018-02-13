using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealmDB.Model;
using Realms;

namespace RealmDB.Database
{
    public class ItemDatabase
    {
        public Realm RealmInstance { get; set; }

        public ItemDatabase()
        {
            RealmInstance = Realm.GetInstance();
        }

        public void SalvarItem(ItemModel itemModel)
        {
            //int Id = 1;
            //var realmInstance = Realm.GetInstance();
            if (RealmInstance.All<ItemModel>().Any())
            {
                var ultimoItem = RealmInstance.All<ItemModel>().OrderByDescending(i => i.Id).First();
                if (ultimoItem != null)
                {
                    itemModel.Id = ultimoItem.Id + 1;
                }
            }
            else
            {
                itemModel.Id = 1;
            }
            RealmInstance.Write(() => { RealmInstance.Add(itemModel); });
        }

        public List<ItemModel> GetItens()
        {
            return RealmInstance.All<ItemModel>().ToList();
        }
    }
}