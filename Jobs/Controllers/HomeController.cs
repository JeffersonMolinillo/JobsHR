using Jobs.Dados;
using Jobs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace Jobs.Controllers
{
    public class HomeController : Controller
    {

        private ProfissionalContext Context { get; set; }

        public HomeController(ProfissionalContext context)
        {
            this.Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        [HttpPost]
        public IActionResult IncluirProfissional(Profissional profissional, IFormFile curriculo)
      {
           if(!ModelState.IsValid)
            {
                return View("Index");
            }

            if (curriculo != null)
            {
                profissional.Curriculo = curriculo.ToByteArray();
                profissional.MimeType = curriculo.ContentType;
            }

            Context.Add<Profissional>(profissional);
            Context.SaveChanges();
            return RedirectToAction("MensagemProfissional");
        }


        [Authorize]
        public FileResult BuscarCurriculo(int? id)
        {
            var evento = Context.Find<Profissional>(id);
            if (evento == null)
            {
                evento.Curriculo = null;
                evento.MimeType = null;
                return File(evento.Curriculo, evento.MimeType);
            }
            return File(evento.Curriculo, evento.MimeType);
        }


        [Authorize]
        public IActionResult ListarCurriculos()
        {
            var lista = Context.Set<Profissional>().ToList();
            return View(lista);
        }

        [Authorize]
        public IActionResult DetalhesProfissional(int id)
        {
            Profissional lista = Context.Profissionais.Find(id);
            return View(lista);
        }


        public IActionResult MensagemProfissional()
        {
            return View("MensagemProfissional");
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult TelaContato()
        {
            return View();
        }

    }
}