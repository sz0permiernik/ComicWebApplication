using ComicWebApplication.CreateViewModels;
using ComicWebApplication.EditViewModels;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;
using ComicWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComicWebApplication.Controllers
{
    public class WorldController : Controller
    {
        private readonly IWorldRepository _worldRepository;
        private readonly IPhotoService _photoService;
        public WorldController(IWorldRepository worldRepository, IPhotoService photoService)
        {
            _worldRepository = worldRepository;
            this._photoService = photoService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            IEnumerable<World> worlds = _worldRepository.GetAllWorlds();

            if (!String.IsNullOrEmpty(searchString))
            {
                worlds = worlds.Where(s => s.Name != null && s.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return View(worlds);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            World world = _worldRepository.GetWorldById(id);
            return View(world);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateWorldViewModel worldViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(worldViewModel.ImageURL);

                var world = new World
                {
                    Name = worldViewModel.Name,
                    Description = worldViewModel.Description,
                    ImageURL = addPhoto.Url.ToString()
                };
                _worldRepository.Add(world);
                return RedirectToAction("Index");
            }

            return View(worldViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var world = _worldRepository.GetWorldById(id);

            var worldViewModel = new EditWorldViewModel
            {
                Name = world.Name,
                Description = world.Description,
                URL = world.ImageURL
            };
            return View(worldViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditWorldViewModel worldViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(worldViewModel.ImageURL);

                var world = new World
                {
                    WorldID = id,
                    Name = worldViewModel.Name,
                    Description = worldViewModel.Description,
                    ImageURL = addPhoto.Url.ToString()
                };

                _worldRepository.Update(world);

                return RedirectToAction("Index");
            }
            return View(worldViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var world = _worldRepository.GetWorldById(id);

            return View(world);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCharacter(int id)
        {
            var world = _worldRepository.GetWorldById(id);

            _worldRepository.Delete(world);
            return RedirectToAction("Index");
        }

    }
}
