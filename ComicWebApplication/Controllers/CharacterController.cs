using ComicWebApplication.CreateViewModels;
using ComicWebApplication.EditViewModels;
using ComicWebApplication.Interfaces;
using ComicWebApplication.Models;
using ComicWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComicWebApplication.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IPhotoService _photoService;
        public CharacterController(ICharacterRepository characterRepository, IPhotoService photoService)
        {
            _characterRepository = characterRepository;
            this._photoService = photoService;
        }

        [HttpGet]
        public IActionResult Index(string searchString)
        {
            IEnumerable<Character> characters = _characterRepository.GetAllCharacters();

            if (!String.IsNullOrEmpty(searchString))
            {
                characters = characters.Where(s => s.Name != null && s.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return View(characters);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Character character = _characterRepository.GetCharacterById(id);
            return View(character);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCharacterViewModel characterViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(characterViewModel.ImageURL);

                var character = new Character
                {
                    Name = characterViewModel.Name,
                    Superpower = characterViewModel.Superpower,
                    Description = characterViewModel.Description,
                    ImageURL = addPhoto.Url.ToString()
                };
                _characterRepository.Add(character);
                return RedirectToAction("Index");
            }

            return View(characterViewModel);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var character = _characterRepository.GetCharacterById(id);

            var characterViewModel = new EditCharacterViewModel
            {
                Name = character.Name,
                Superpower = character.Superpower,
                Description = character.Description,
                URL = character.ImageURL
            };
            return View(characterViewModel); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCharacterViewModel characterViewModel)
        {
            if (ModelState.IsValid)
            {
                var addPhoto = await _photoService.AddPhotoAsync(characterViewModel.ImageURL);

                var character = new Character
                {
                    CharacterID = id,
                    Name = characterViewModel.Name,
                    Superpower = characterViewModel.Superpower,
                    Description = characterViewModel.Description,
                    ImageURL = addPhoto.Url.ToString()
                };

                _characterRepository.Update(character);
                return RedirectToAction("Index");
            }
            return View(characterViewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var character = _characterRepository.GetCharacterById(id);

            return View(character);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCharacter(int id)
        {
            var character = _characterRepository.GetCharacterById(id);

            _characterRepository.Delete(character);
            return RedirectToAction("Index");
        }
    }
}
