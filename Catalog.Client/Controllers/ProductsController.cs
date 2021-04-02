using Catalog.Client.ApiServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Client.Controllers
{
    
    public class ProductsController : Controller
    {
        private readonly IProductApiService productApiService;

        public ProductsController(IProductApiService productApiService)
        {
            this.productApiService = productApiService ?? throw new ArgumentNullException(nameof(productApiService));
        }

        [HttpGet]
        public IActionResult Index1()
        {
            return View();
        }
    }
}
