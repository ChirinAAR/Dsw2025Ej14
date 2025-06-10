using __Dsw2025Ej14.Api__.Domain;
using System.Text.Json;

namespace __Dsw2025Ej14.Api__.Data
{
   public class PersistenciaEnMemoria
    {
        private List<Product> lista = new();
        private void LoadProducts()
        {
            var json = File.ReadAllText("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            })?? [];
            if (products != null)
                lista = products;
        }
        public Product GetProduct(string sku)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return lista;
        }
    }
}
