using Microsoft.AspNetCore.Mvc;
using Prueba02DeWebMovel.Controllers.Base;
using Prueba02DeWebMovel.Data;
using Prueba02DeWebMovel.Model;

namespace Prueba02DeWebMovel.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetProducts()
        {

        }


        //Httptipo
        //async Task<ActionResult<List<Entity>>>
        /*{
            var entity = await _context.Entity.Where(u => u.Id == 1).ToListAsync();
            return entity;*/

    }
}

