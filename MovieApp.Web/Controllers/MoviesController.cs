using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Model;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {

        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();

        }
        public IActionResult List(int? id,string q)
        {

            //         var controller = RouteData.Values["controller"];
            //         var action = RouteData.Values["action"];
            //         var genreid = RouteData.Values["genreid"];

            //var kelime = HttpContext.Request.Query["q"].ToString();    // arama kısmında gelen kelimeyi bulmanın bir diğer yolu olarak tanımladık

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();


            if (id != null)
            {
                movies = movies.Where(m=>m.GenreId == id);
            }
            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i =>
                i.Title.ToLower().Contains(q.ToLower()) ||
                i.Description.ToLower().Contains(q.ToLower()) ||
                i.Director.ToLower().Contains(q.ToLower()));
            }
            var model = new MoviesViewModel()
            {
                Movies = movies.ToList()
            };
            return View("List",model);
        }
        //local Host: 5000/movies/details
        public IActionResult Details(int id)
        {
                //return View(MovieRepository.GetById(id));
                return View(_context.Movies.Find(id));
        }
        public IActionResult Create()
        {
			ViewBag.Genres = new SelectList(/*GenreRepository.Genres*/ _context.Genres.ToList(), "GenreId", "Name");
			return View();
        }
        [HttpPost]
		public IActionResult Create(Movie m)
		
        {

            if (ModelState.IsValid)
            {
				//MovieRepository.Add(m);
                _context.Movies.Add(m);
                _context.SaveChanges();
				TempData["Message"] = $"{m.Title} İsimli Film/Dizi Başarıyla Eklendi.";

				return RedirectToAction("List");
			}
			ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");

			return View();

         
		}

        [HttpGet]
		public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
                 var movie = _context.Movies.Find(id);


                  if (movie == null)
                     {
                         return NotFound(); // veya başka bir işlem yapabilirsiniz, örneğin NotFound sayfasına yönlendirme
                     }

                     return View(movie);
         }


		[HttpPost]
		public IActionResult Edit(Movie m)
		{

			if (ModelState.IsValid)
			{
				//MovieRepository.Edit(m);
                _context.Movies.Update(m);
				_context.SaveChanges();

				return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
			}
			ViewBag.Genres = new SelectList(_context.Genres.ToList() , "GenreId", "Name");
                
			return View(m);
			
		}

		[HttpPost]
		public IActionResult Delete(int MovieId,string Title)
		{

            //MovieRepository.Delete(MovieId);
            var entity = _context.Movies.Find(MovieId);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            TempData["Message"]=$"{Title} İsimli Film/Dizi Başarıyla Silindi." ;
            return RedirectToAction("List");

		}
	}
}
