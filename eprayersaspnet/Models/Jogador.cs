using System.Collections.Generic;
using System.IO;
using eprayersaspnet.Interfaces;

namespace eprayersaspnet.Models
{
    public class Jogador : EplayersBase, IJogador
    {
        public int IdJogador { get; set; }
        
        public string NomeJogador { get; set; }
        
        public int IdEquipePlayer { get; set; }

        public string Email{get; set;}

        public string Senha{get; set;}

        private const string CAMINHO = "Database/jogador.csv";

        public Jogador(){
            CriarPastaEArquivo(CAMINHO);
        }

        private string Preparar(Jogador j){
            return $"{j.IdJogador};{j.NomeJogador};{j.IdEquipePlayer};{j.Email};{j.Senha}";
        }

        public void Criar(Jogador e)
        {
            string[] linha = {Preparar(e)};
            File.AppendAllLines(CAMINHO, linha);

        }

        public List<Jogador> LerTodas()
        {
             List<Jogador> LerJogadores = new List<Jogador>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas){
                string[] linha = item.Split(";");

                Jogador jogador = new Jogador();

                jogador.IdJogador = int.Parse(linha[0]);
                jogador.NomeJogador = linha[1];
                jogador.IdEquipePlayer = int.Parse(linha[2]);
                jogador.Email = linha[3];
                jogador.Senha = linha[4];

                LerJogadores.Add(jogador);
            }
           return LerJogadores;
        }

        public void Alterar(Jogador e)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdJogador.ToString());
            linhas.Add(Preparar(e));
            ReescreverCSV(CAMINHO, linhas);
        }

        public void Deletar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}