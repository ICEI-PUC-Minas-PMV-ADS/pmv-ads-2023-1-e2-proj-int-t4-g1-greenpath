using GreenPath.Data;
using GreenPath.Interfaces;
using GreenPath.Models;
using GreenPath.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GreenPath.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly BancoContexto _context;
        private readonly ILocationService _locationService;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            BancoContexto context,
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
            else
            {
                var user = await _userManager.FindByEmailAsync(registerViewModel.EmailAddress);
                if (user != null)
                {
                    TempData["Error"] = "Este endereço de e-mail já está cadastrado.";
                    return View(registerViewModel);
                }
                else
                {
                    //usando o tempData para persistir os dados de autenticação (email, senha, conf. de senha)
                    TempData["RegisterViewModel"] = JsonConvert.SerializeObject(registerViewModel);
                    return RedirectToAction("Data", "Account");
                }
            }

        }

        [HttpGet]
        public Task<IActionResult> Data()
        {
			return Task.FromResult<IActionResult>(View());
        }

        [HttpPost]
        public async Task<IActionResult> Data(DataViewModel dataViewModel, string tipoUsuario)
        {
            if (!ModelState.IsValid)
            {
                return View(dataViewModel);
            }

            var check = new CheckData(tipoUsuario, dataViewModel);

            if (!check.isValid())
            {
                TempData["DataError"] = check.CheckFields() + " são inválidos.";
                return View(dataViewModel);
            }
            else
            {

                if (TempData.ContainsKey("RegisterViewModel"))
                {
                    if(string.IsNullOrEmpty(TempData["RegisterViewModel"] as string)){

                    var serializedData = TempData["RegisterViewModel"] as string;
                    if (!string.IsNullOrEmpty(serializedData))
                    {
                        var userAuthenticationData = JsonConvert.DeserializeObject<RegisterViewModel>(serializedData);

                        if (userAuthenticationData != null)
                        {
                            // Criar autenticação
                            var newUser = new AppUser()
                            {
                                Email = userAuthenticationData.EmailAddress,
                                UserName = userAuthenticationData.EmailAddress
                            };
                            
                            var newUserResponse = await _userManager.CreateAsync(newUser, userAuthenticationData.Password);

                            if (newUserResponse.Succeeded)
                            {
                                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

                                //Inserir dados
                                var pessoaFisica = new PessoaFisicaModel
                                {
                                    // Defina as propriedades da entidade PessoaFisicaModel
                                    Id = newUser.Id, // Atribua o Id do usuário encontrado
                                    Nome = dataViewModel.Name,
                                    Cpf = "15169348802",
                                    Sobrenome = dataViewModel.Surname,
                                    Area = dataViewModel.Profession
                                };

                                _context.PessoaFisica.Add(pessoaFisica);
                                await _context.SaveChangesAsync();
                            }

                            return RedirectToAction("Welcome", "Account");
                        }
                    }
                    }else{
                        return Problem("Faça registro primeiro !");
                    }
                }
            }


            // Tratar a situação em que ocorre um erro ou os dados são inválidos
            return RedirectToAction("Error", "Home");
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("Account/Welcome")]
        public Task<IActionResult> Welcome(int page = 0)
        {
            if (page == 0)
            {
                return Task.FromResult<IActionResult>(View());
            }
            return Task.FromResult<IActionResult>(View());

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