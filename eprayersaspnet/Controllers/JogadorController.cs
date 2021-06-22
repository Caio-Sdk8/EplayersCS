using eprayersaspnet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eprayersaspnet.Controllers
{
    [Route("Jogadores")]
    public class JogadorController : Controller
    {
        Jogador jogadormodel = new Jogador();
        public IActionResult Index()
        {
            ViewBag.LerJogadores = jogadormodel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novojogador = new Jogador();

            novojogador.IdJogador = int.Parse(form["IdJogador"]);
            novojogador.IdEquipePlayer = int.Parse(form["IdEquipePlayer"]);
            novojogador.NomeJogador = form["Nome"];
            novojogador.Email = form["Email"];
            novojogador.Senha = form["Senha"];

            jogadormodel.Criar(novojogador);
            ViewBag.LerJogadores = jogadormodel.LerTodas();

            return LocalRedirect("~/Jogador/Listar");
        }
    }
}