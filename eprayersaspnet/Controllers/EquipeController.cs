using System.IO;
using eprayersaspnet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eprayersaspnet.Controllers
{

    [Route("Equipe")]
    public class EquipeController : Controller
    {
        Equipe equiperan = new Equipe();
        Equipe equipeModel = new Equipe();

        [Route("listar")]
        public IActionResult Index()
        {

            ViewBag.Equipes = equipeModel.LerTodas();
            return View();
        }

        
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            equiperan.i++;
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = $"#BR{equiperan.i}";
            novaEquipe.NomeEquipe = form["NomeEquipe"];

            if (form.Files.Count > 0)
            {

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                novaEquipe.LogoTime = file.FileName;
            }
            else{
                novaEquipe.LogoTime = "padrao.png";
            }

            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.LerTodas();

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("{id}")]
        public IActionResult Excluir(string id){
            equipeModel.Deletar(id);
            ViewBag.Equipes = equipeModel.LerTodas();
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}