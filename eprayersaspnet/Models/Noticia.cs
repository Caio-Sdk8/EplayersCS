using System.Collections.Generic;
using eprayersaspnet.Interfaces;

namespace eprayersaspnet.Models
{
    public class Noticia : EplayersBase, INoticia
    {
        public int IdNoticia { get; set; }
        
        public string Titulo { get; set; }
        
        public string Texto { get; set; }
        
        public string Imagem { get; set; }
        
        private const string CAMINHO = "Database/noticia.csv";

        public Noticia(){
            CriarPastaEArquivo(CAMINHO);
        }

        public void Criar(Noticia e)
        {
            throw new System.NotImplementedException();
        }

        public List<Noticia> LerTodas()
        {
            throw new System.NotImplementedException();
        }

        public void Alterar(Noticia e)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}