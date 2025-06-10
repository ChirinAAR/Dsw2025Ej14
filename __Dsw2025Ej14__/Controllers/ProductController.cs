using Microsoft.AspNetCore.Mvc;
using __Dsw2025Ej14.Api__.Data;
using __Dsw2025Ej14.Api__.Domain;


namespace __Dsw2025Ej14.Api__.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductController :  Controller
    {

        private readonly PersistenciaEnMemoria persis;

        public ProductController(PersistenciaEnMemoria persistencia)
        {
            persis = persistencia;
        }
        [HttpGet]
        public IActionResult GetActiveProducts()
        {
            var products = persis.GetProducts().ToList();
            return Ok(products);
        }

        [HttpGet("{sku}")]
        public IActionResult GetProductBySku(string sku)
        {
            var product = persis.GetProduct(sku);
            return Ok(product);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
