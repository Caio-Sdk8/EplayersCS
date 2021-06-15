using System.Collections.Generic;
using eprayersaspnet.Interfaces;

namespace eprayersaspnet.Models
{
    public class Jogador : EplayersBase, IJogador
    {
        public int IdJogador { get; set; }
        
        public string NomeJogador { get; set; }
        
        public int IdEquipePlayer { get; set; }

        private const string CAMINHO = "Database/jogador.csv";

        public Jogador(){
            CriarPastaEArquivo(CAMINHO);
        }

        private string Preparar(Jogador j){
            return $"{j.IdJogador};{j.NomeJogador};{j.IdEquipePlayer}";
        }

        public void Criar(Jogador e)
        {
            throw new System.NotImplementedException();
        }

        public List<Jogador> LerTodas()
        {
            throw new System.NotImplementedException();
        }

        public void Alterar(Jogador e)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}