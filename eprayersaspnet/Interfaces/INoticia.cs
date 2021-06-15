using System.Collections.Generic;
using eprayersaspnet.Models;

namespace eprayersaspnet.Interfaces
{
    public interface INoticia
    {
         void Criar(Noticia e);

        List<Noticia> LerTodas();

        void Alterar(Noticia e);

        void Deletar(int id);
    }
}