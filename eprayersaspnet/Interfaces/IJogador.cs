using System.Collections.Generic;
using eprayersaspnet.Models;

namespace eprayersaspnet.Interfaces
{
    public interface IJogador
    {
        void Criar(Jogador e);

        List<Jogador> LerTodas();

        void Alterar(Jogador e);

        void Deletar(int id);
    }
}