using System;
using GP23.Data;
using GP23.Interfaces;
using GP23.Models;
using GP23.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GP23.Controllers
{
        public class AccountController : Controller
        {
            private readonly UserManager<AppUser> _userManager;
            private readonly SignInManager<AppUser> _signInManager;
            private readonly ApplicationDbContext _context;
            private readonly ILocationService _locationService;

            public AccountController(UserManager<AppUser> userManager,
                SignInManager<AppUser> signInManager,
                ApplicationDbContext context,
                ILocationService locationService)
            {
                _context = context;
                _locationService = locationService;
                _signInManager = signInManager;
                _userManager = userManager;
            }

            [HttpGet]
            public IActionResult Login()
            {
                var response = new LoginViewModel();
                return View(response);
            }

        //Verificação de Login e mensagens de erro para dados incorretos
            [HttpPost]
            public async Task<IActionResult> Login(LoginViewModel loginViewModel)
            {
                if (!ModelState.IsValid) return View(loginViewModel);

                var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);

                if (user != null)
                {
                    //User encontrado, password verificado
                    var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                    if (passwordCheck)
                    {
                        //Password correcto, sign in
                        var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    //Password esta errado
                    TempData["Error"] = "Dados incorretos. Por favor, tente novamente.";
                    return View(loginViewModel);
                }
                //User não encontrado
                TempData["Error"] = "Dados incorretos. Por favor, tente novamente.";
                return View(loginViewModel);
            }

        //Registro de novo usuário e verificação se o e-mail já existe no Db
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

                var user = await _userManager.FindByEmailAsync(registerViewModel.EmailAddress);
                if (user != null)
                {
                    TempData["Error"] = "Este endereço de e-mail já foi usado.";
                    return View(registerViewModel);
                }

                var newUser = new AppUser()
                {
                    Email = registerViewModel.EmailAddress,
                    UserName = registerViewModel.EmailAddress
                };
                var newUserResponse = await _userManager.CreateAsync(newUser, registerViewModel.Password);

                if (newUserResponse.Succeeded)
                    await _userManager.AddToRoleAsync(newUser, UserRoles.User);

                return RedirectToAction("Welcome", "Account");
            }

            [HttpGet]
            public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }



           [HttpGet]
           [Route("Account/Welcome")]
           public async Task<IActionResult> Welcome(int page = 0)
           {
              if (page == 0)
              {
                 return View();
              }
              return View();

           }

            [HttpGet]
            public async Task<IActionResult> GetLocation(string location)
            {
                if (location == null)
                {
                    return Json("Não encontrado");
                }
                var locationResult = await _locationService.GetLocationSearch(location);
                return Json(locationResult);
            }


        }

}