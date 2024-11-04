using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Aplicacao_A1.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_A1.Controllers
{
    public class PublicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PublicController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Ação para a página pública de produtos
        public async Task<IActionResult> Produtos()
        {
            var produtos = await _context.Produtos.Include(p => p.Categoria).ToListAsync(); // Carrega produtos do banco de dados
            return View(produtos);
        }

        // Ação para a página "Sobre a Distribuidora"
        public IActionResult Sobre()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }
    }
}
    