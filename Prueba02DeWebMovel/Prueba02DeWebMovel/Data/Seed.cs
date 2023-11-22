using Prueba02DeWebMovel.Model;
using System.Text.Json;

namespace Prueba02DeWebMovel.Data
{
    public class Seed
    {
        /**Metodo para Acceder al proceso de deseriealizacion los archivos que están en formato JSON**/
        public static void SeedData(DataContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            CallEachSeeder(context, options);

        }
        /**Lee archivo por archivo en formato Json**/
        public static void CallEachSeeder(DataContext context, JsonSerializerOptions options)
        {
            SeedTables(context, options);
            

        }

        /**Estos métodos se llamaran primero**/
        private static void SeedTables(DataContext context, JsonSerializerOptions options)
        {
            SeedProducts(context, options);
            context.SaveChanges();
        }

        /**Método para cargar los roles**/
        private static void SeedProducts(DataContext context, JsonSerializerOptions options)
        {
            
            var result = context.Products?.Any();
            if (result is true or null) return;//no lo entontro
            var productsData = File.ReadAllText("Data/Seeders/Products.json");//lee el archivo
            var productsList = JsonSerializer.Deserialize<List<Producto>>(productsData, options);//lo deserializa
            if (productsList == null) return;//en caso que no hayan productos, pasa nada
            // Eso si siempre habrá una lista de entidades
            // El mensaje de advertencia
            if (context.Products == null) throw new Exception("");
            context.Products.AddRange(productsList);
            context.SaveChanges();
        }


        

    }
}
