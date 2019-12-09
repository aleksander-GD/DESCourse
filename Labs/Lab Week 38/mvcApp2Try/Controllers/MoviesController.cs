using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvcApp2Try.Models;

namespace mvcApp2Try.Controllers
{
    public class MoviesController : Controller
    {
        /**
         * The constructor uses Dependency Injection to inject the database context (MvcMovieContext) into the controller. 
         * The database context is used in each of the CRUD methods in the controller.
         */
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        // GET: Movies
        /*
         * Notice how the code creates a List object when it calls the View method. 
         * The code passes this Movies list from the Index action method to the view:
         */

        // There's no [HttpPost] overload of the Index method as you might expect. 
        /**
         * You could add the following [HttpPost] Index method.
         * [HttpPost]
            public string Index(string searchString, bool notUsed)
            {
                   return "From [HttpPost]Index: filter on " + searchString;
            }
         */

        
        public async Task<IActionResult> Index(string searchString)
        {
            // The first line of the Index action method creates a LINQ query to select the movies:
            var movies = from m in _context.Movie
                         select m;

            // If the searchString parameter contains a string, the movies query is modified to filter on the value of the search string
            if (!String.IsNullOrEmpty(searchString))
            {
                /*
                 * The Contains method is run on the database, not in the c# code shown above. 
                 * The case sensitivity on the query depends on the database and the collation. 
                 * On SQL Server, Contains maps to SQL LIKE, which is case insensitive. In SQLite, 
                 * with the default collation, it's case sensitive.
                 */
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }

        // GET: Movies/Details/5

        /**
         * The id parameter is generally passed as route data. 
         * For example https://localhost:5001/movies/details/1 sets:
         *      * The controller to the movies controller (the first URL segment).
         *      * The action to details (the second URL segment).
         *      * The id to 1 (the last URL segment).
         *      
         * You can also pass in the id with a query string as follows:
         *      https://localhost:5001/movies/details?id=1
         * The id parameter is defined as a nullable type (int?) in case an ID value isn't provided.
         */
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*
             * A lambda expression is passed in to FirstOrDefaultAsync to 
             * select movie entities that match the route data or query string value.
             */
            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            // If a movie is found, an instance of the Movie model is passed to the Details view:
            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
