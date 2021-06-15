using System;
using System.Collections.Generic;
using eprayersaspnet.Interfaces;

namespace eprayersaspnet.Models
{
    public class Partida : EplayersBase, IPartida
    {
        public int IdPartida { get; set; }
        
        public int IdJogador1 {get; set;}

        public int IdJogador2 {get; set;}

        public DateTime HorarioInicio {get; set;}

        public DateTime HorarioTermino {get; set;}

        private const string CAMINHO = "Database/Partida.csv";

        public Partida(){
            CriarPastaEArquivo(CAMINHO);
        }


        public void Criar(Partida e)
        {
            throw new NotImplementedException();
        }

        public List<Partida> LerTodas()
        {
            throw new NotImplementedException();
        }

        public void Alterar(Partida e)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}