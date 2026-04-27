using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppParcial1.Data;

namespace WebAppParcial1.Controllers
{
    public class InicioController : Controller
    {
        private readonly AppDBcontext _context;

        public InicioController()
        {
            _context = new AppDBcontext();
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var appDBcontext = _context.productos.Include(p => p.categoria);
            return View(await appDBcontext.ToListAsync());
        }
    }
}
