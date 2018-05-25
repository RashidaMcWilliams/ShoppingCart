using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Controllers
{
    public class SampleController : Controller
	{
        // 
        // GET: /Sample/

		public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Sample/Welcome/
		// Requires using System.Text.Encodings.Web;

		public string Welcome(string name)
		{
            return HtmlEncoder.Default.Encode($"Hello {name}");
        }
    }
}
