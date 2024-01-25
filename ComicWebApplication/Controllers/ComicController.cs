using ComicWebApplication.CreateViewModels;
using ComicWebApplication.EditViewModels;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;
using ComicWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComicWebApplication.Controllers
{
    public class ComicController : Controller
    {
        private readonly IComicRepository _comicRepository;
        private readonly IPhotoService _photoService;
        public ComicController(IComicRepository comicRepository, IPhotoService photoService)
        {
            _comicRepository = comicRepository;
            this._photoService = photoService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            IEnumerable<Comic> comics = _comicRepository.GetAllComics();

            if (!String.IsNullOrEmpty(searchString))
            {
                comics = comics.Where(s => s.Title != null && s.Title.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return View(comics);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Comic comic = _comicRepository.GetComicById(id);
            return View(comic);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateComicViewModel comicViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(comicViewModel.ImageURL);

                var comic = new Comic
                {
                    Title = comicViewModel.Title,
                    Number = comicViewModel.Number,
                    Description = comicViewModel.Description,
                    ReleaseYear = comicViewModel.ReleaseYear,
                    ImageURL = addPhoto.Url.ToString()
                };
                _comicRepository.Add(comic);
                return RedirectToAction("Index");
            }

            return View(comicViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var comic = _comicRepository.GetComicById(id);

            var comicViewModel = new EditComicViewModel
            {
                Title = comic.Title,
                Number = comic.Number,
                Description = comic.Description,
                ReleaseYear = comic.ReleaseYear,
                URL = comic.ImageURL
            };
            return View(comicViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditComicViewModel comicViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(comicViewModel.ImageURL);

                var comic = new Comic
                {
                    ComicID = id,
                    Title = comicViewModel.Title,
                    Number = comicViewModel.Number,
                    Description = comicViewModel.Description,
                    ReleaseYear = comicViewModel.ReleaseYear,
                    ImageURL = addPhoto.Url.ToString()
                };

                _comicRepository.Update(comic);

                return RedirectToAction("Index");
            }
            return View(comicViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var comic = _comicRepository.GetComicById(id);

            return View(comic);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCharacter(int id)
        {
            var comic = _comicRepository.GetComicById(id);

            _comicRepository.Delete(comic);
            return RedirectToAction("Index");
        }
    }
}
