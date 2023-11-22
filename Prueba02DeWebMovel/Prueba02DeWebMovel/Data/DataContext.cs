using Microsoft.EntityFrameworkCore;
using Prueba02DeWebMovel.Model;

namespace Prueba02DeWebMovel.Data
{
    public class DataContext : DbContext
    {

        /**DE AQUI se crean las migraciones**/
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Producto> Products { get; set; }

        

        /**Este metodo no es necesario pero sirve para construir relaciones de N a N y transformar fechas y/u horas**/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
