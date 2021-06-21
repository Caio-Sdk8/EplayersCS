using System;
using System.Collections.Generic;
using System.IO;
using eprayersaspnet.Interfaces;

namespace eprayersaspnet.Models
{
    public class Equipe : EplayersBase, IEquipe
    {
        public int i = 0;
        public string IdEquipe { get; set; }

        public string NomeEquipe { get; set; }
        
        public string LogoTime {get; set;}

        private const string CAMINHO = "Database/equipe.csv";

        public Equipe(){
            CriarPastaEArquivo(CAMINHO);
        }

        private string Preparar(Equipe e){
            return $"{e.IdEquipe};{e.NomeEquipe};{e.LogoTime}";
        }

        public void Alterar(Equipe e)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            linhas.Add(Preparar(e));
            ReescreverCSV(CAMINHO, linhas);
        }

        public void Criar(Equipe e)
        {
            string[] linha = {Preparar(e)};
            File.AppendAllLines(CAMINHO, linha);
        }

        public void Deletar(string id)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            ReescreverCSV(CAMINHO, linhas);
        }

        public List<Equipe> LerTodas()
        {
            List<Equipe> LerEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas){
                string[] linha = item.Split(";");

                Equipe equipe = new Equipe();

                equipe.IdEquipe = linha[0];
                equipe.NomeEquipe = linha[1];
                equipe.LogoTime = linha[2];

                LerEquipes.Add(equipe);
            }
           return LerEquipes;
        }
    }
}