using AgriEnergyConnect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Controllers
{
    [Authorize(Roles = "Employee")]
    public class ProductManagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string category, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category.Contains(category));
            }

            if (startDate.HasValue)
            {
                query = query.Where(p => p.ProductionDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(p => p.ProductionDate <= endDate.Value);
            }

            var products = await query.ToListAsync();
            return View(products);
        }
    }

}
