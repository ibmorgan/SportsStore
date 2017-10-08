using SportsStore.Domain.Abstract;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }
        
        // GET: Product
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}