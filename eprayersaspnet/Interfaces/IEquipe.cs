using System.Collections.Generic;
using eprayersaspnet.Models;

namespace eprayersaspnet.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);

        List<Equipe> LerTodas();

        void Alterar(Equipe e);

        void Deletar(int id);
    }
}