using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        /**
         * 
         * You create a view template file using Razor. 
         * Razor-based view templates have a .cshtml file extension. 
         * They provide an elegant way to create HTML output with C#.
         * 
         * The preceding code calls the controller's View method. 
         * It uses a view template to generate an HTML response. 
         * Controller methods (also known as action methods), 
         * such as the Index method above, generally return an IActionResult 
         * (or a class derived from ActionResult), not a type like string.
         */
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        /**
         * The ViewData dictionary object contains data that will be passed to the view.
         */
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        //
        // GET: /HelloWorld/Name/

        /**
         * https://localhost:44359/HelloWorld/NameNumtimes?name=Rick&numtimes=10
         * In the image above, the URL segment (Parameters) isn't used, the name and numTimes parameters are passed as query strings. 
         * The ? (question mark) in the above URL is a separator, and the query strings follow. 
         * The & character separates query strings 
         */
        public string NameNumtimes(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        //
        // GET: /HelloWorld/Name/

        /**
         * https://localhost:44359/HelloWorld/Nameid/20?name=Aleksander
         * 
         * This time the third URL segment matched the route parameter id. 
         * The Welcome method contains a parameter id that matched the URL template in the MapRoute method. 
         * The trailing ? (in id?) indicates the id parameter is optional.
         * 
         * 
         */
        public string Nameid(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
