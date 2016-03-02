using System.Collections.Generic;
using System.Web.Http;
using AngularMvcStarter.ViewModels;

namespace AngularMvcStarter.Controllers.Api
{
    public class ProductsController : ApiController
    {
        [Route("api/products/{productName}")]
        public IList<Product> Get(string productName)
        {
            return new List<Product>
            {
                new Product {ProductId = 1, Name = "Adjustable Race", ProductNumber = "AR-5381"},
                new Product {ProductId = 2, Name = "Bearing Ball", ProductNumber = "BA-8327"},
                new Product {ProductId = 3, Name = "BB Ball Bearing", ProductNumber = "BE-2349"}
            };
        }
    }
}
