using ComicWebApplication.CreateViewModels;
using ComicWebApplication.EditViewModels;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;
using ComicWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComicWebApplication.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IPhotoService _photoService;
        public MovieController(IMovieRepository movieRepository, IPhotoService photoService)
        {
            _movieRepository = movieRepository;
            this._photoService = photoService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            IEnumerable<Movie> movies = _movieRepository.GetAllMovies();

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title != null && s.Title.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return View(movies);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Movie movie = _movieRepository.GetMovieById(id);
            return View(movie);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMovieViewModel movieViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(movieViewModel.ImageURL);

                var movie = new Movie
                {
                    Title = movieViewModel.Title,
                    Director = movieViewModel.Director,
                    Description = movieViewModel.Description,
                    ReleaseYear = movieViewModel.ReleaseYear,
                    ImageURL = addPhoto.Url.ToString()
                };
                _movieRepository.Add(movie);
                return RedirectToAction("Index");
            }

            return View(movieViewModel);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _movieRepository.GetMovieById(id);

            var movieViewModel = new EditMovieViewModel
            {
                Title = movie.Title,
                Director = movie.Director,
                Description = movie.Description,
                ReleaseYear = movie.ReleaseYear,
                URL = movie.ImageURL
            };
            return View(movieViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditMovieViewModel movieViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(movieViewModel.ImageURL);

                var movie = new Movie
                {
                    MovieID = id,
                    Title = movieViewModel.Title,
                    Director = movieViewModel.Director,
                    Description = movieViewModel.Description,
                    ReleaseYear = movieViewModel.ReleaseYear,
                    ImageURL = addPhoto.Url.ToString()
                };

                _movieRepository.Update(movie);

                return RedirectToAction("Index");
            }
            return View(movieViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieRepository.GetMovieById(id);

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = _movieRepository.GetMovieById(id);

            _movieRepository.Delete(movie);
            return RedirectToAction("Index");
        }
    }
}
