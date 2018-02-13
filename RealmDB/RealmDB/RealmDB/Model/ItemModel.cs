using System.ComponentModel.DataAnnotations;
using Realms;

namespace RealmDB.Model
{
    public class ItemModel : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Nome { get; set; }

        [Range(1, 9999)]
        public int Quantidade { get; set; }
    }
}