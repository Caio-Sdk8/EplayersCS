using System.Collections.Generic;
using eprayersaspnet.Models;

namespace eprayersaspnet.Interfaces
{
    public interface IPartida
    {
         void Criar(Partida e);

        List<Partida> LerTodas();

        void Alterar(Partida e);

        void Deletar(int id);
    }
}