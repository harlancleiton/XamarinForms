using System.Collections.Generic;

namespace ListViewAvancado.Model
{
    public class Grupo : List<Pessoa>
    {
        public string Titulo { get; set; }
        public string TituloCurto { get; set; }
        public string Descricao { get; set; }

        public Grupo(string titulo, string tituloCurto)
        {
            this.Titulo = titulo;
            this.TituloCurto = tituloCurto;
        }

        public Grupo(string titulo, string tituloCurto, string descricao)
        {
            this.Titulo = titulo;
            this.TituloCurto = tituloCurto;
            this.Descricao = descricao;
        }
    }
}
