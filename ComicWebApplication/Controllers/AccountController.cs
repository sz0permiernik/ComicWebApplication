using Microsoft.AspNetCore.Mvc;
using ComicWebApplication.ViewModel;
using Microsoft.AspNetCore.Identity;
using ComicWebApplication.Models;
using ComicWebApplication.Data;

namespace ComicWebApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var login = new LoginViewModel();
            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

                if (user != null)
                {
                    var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                    if (passwordCheck)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                        if (result.Succeeded) return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Nieprawidłowe hasło.");
                    }
                    return View(loginViewModel);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Nieznaleziono użytkownika.");
                }
                return View(loginViewModel);
            }

            return View(loginViewModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var response = new RegisterViewModel();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            var user = await _userManager.FindByEmailAsync(registerViewModel.Email);

            if (user != null)
            {
                ModelState.AddModelError(string.Empty, "Email już istnieje.");
                return View(registerViewModel);
            }

            var newRegister = new ApplicationUser()
            {
                Email = registerViewModel.Email,
                UserName = registerViewModel.Email,
            };

            var newRegisterResponse = await _userManager.CreateAsync(newRegister, registerViewModel.Password);

            if (newRegisterResponse.Succeeded)
                await _userManager.AddToRoleAsync(newRegister, UserRoles.User);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
