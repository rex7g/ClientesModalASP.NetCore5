using Clientes.Data;
using Clientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Clientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;

        }


        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Crear(int? id)
        {
            Cliente cliente = new Cliente();
            return View();
        }

        //guardando los datos en la db y representandolos en la vista cliente

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                await _db.Cliente.AddAsync(cliente);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Crear));
            }
            return View(cliente);
           
        }
        [HttpGet]
        public async Task<IActionResult>ObtenerTodos()
        {
            var todos = await _db.Cliente.ToArrayAsync();
          return Json(new { data = todos});
          
        }



    }
}
