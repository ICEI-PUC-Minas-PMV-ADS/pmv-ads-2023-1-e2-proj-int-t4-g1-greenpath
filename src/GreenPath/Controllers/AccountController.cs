using GreenPath.Data;
using GreenPath.Interfaces;
using GreenPath.Models;
using GreenPath.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

        private void InsertCerts(string JuriId, int CertId)
        {
            using (SqlConnection con = new SqlConnection("Server=greenpath.database.windows.net;Initial Catalog=greenpath;Integrated Security=False;User Id=caminhoverde;Password=c6jmeNsmQyzgtLG"))
            {
                string query = "INSERT INTO Pessoa_Juri_Certificacao (pessoa_juri_id,cert_id) VALUES (@JuriId, @CertId)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@JuriId", JuriId);
                    cmd.Parameters.AddWithValue("@CertId", CertId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
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
            DataViewModel model = new DataViewModel();
            List<CertificacaoModel> certs = _context.Certificacoes.AsNoTracking().ToList();

            foreach (var item in certs)
            {
                item.isChecked = false;
            }

            model.Certificates = certs;

            // Console.WriteLine("------------->  "+model.Certificates.Count());
            
			return Task.FromResult<IActionResult>(View(model));
        }

        [HttpPost]
        public async Task<IActionResult> Data(DataViewModel dataViewModel, string tipoUsuario)
        {
            //_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            List<EmpresaModel> empresas = _context.Empresas.AsNoTracking().ToList();

            var check = new CheckData(tipoUsuario, dataViewModel);

            if (!check.isValid())
            {
                TempData["DataError"] = check.CheckFields() + " são inválidos.";
                return View(dataViewModel);
            }
            else
            {
                foreach (var item in empresas)
                {
                    if(!(string.IsNullOrWhiteSpace(item.Cnpj)) && item.Cnpj == dataViewModel.CNPJ){
                        return PartialView("~/Views/Shared/_AlertMessage.cshtml", "Empresa já cadastrada!");
                    } 
                }

                if (TempData.ContainsKey("RegisterViewModel"))
                {
                    if(!string.IsNullOrEmpty(TempData["RegisterViewModel"] as string)){

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
                               if(tipoUsuario == "candidato"){
                                    //Inserir dados
                                    var pessoaFisica = new PessoaFisicaModel
                                    {
                                        // Defina as propriedades da entidade PessoaFisicaModel
                                        Id = newUser.Id, // Atribua o Id do usuário encontrado
                                        Nome = dataViewModel.Name,
                                        Cpf = dataViewModel.CPF,
                                        Sobrenome = dataViewModel.Surname,
                                        Area = dataViewModel.Profession,
                                        Pais = dataViewModel.Country,
                                        Estado = dataViewModel.State,
                                        Cidade = dataViewModel.City,
                                        Telefone = dataViewModel.Phone,
                                        Email = dataViewModel.Email,
                                        Github = dataViewModel.Github,
                                        Instagram = dataViewModel.Instagram,
                                        Facebook = dataViewModel.Facebook,
                                        Pinterest = dataViewModel.Pinterest
                                    };
                                    
                                    await _userManager.AddToRoleAsync(newUser, "userPF");

                                    _context.PessoaFisica.Add(pessoaFisica);
                                    await _context.SaveChangesAsync();

                               }

                               else{
                                    var pessoaJuri = new EmpresaModel
                                    {
                                        // Defina as propriedades da entidade PessoaFisicaModel
                                        Id = newUser.Id, // Atribua o Id do usuário encontrado
                                        Razao = dataViewModel.CompanyName,
                                        Cnpj = dataViewModel.CNPJ,
                                        Area = dataViewModel.Area,
                                        Pais = dataViewModel.Country,
                                        Estado = dataViewModel.State,
                                        Cidade = dataViewModel.City,
                                        Telefone = dataViewModel.Phone,
                                        Email = dataViewModel.Email
                                    };

                                    await _userManager.AddToRoleAsync(newUser, "userPJ");

                                    _context.Empresas.Add(pessoaJuri);
                                    await _context.SaveChangesAsync();


                                    var selectedCertificates = dataViewModel.Certificates.Where(x => x.isChecked).ToList();

                                    foreach (var item in selectedCertificates)
                                    {
                                        InsertCerts(pessoaJuri.Id, (int)item.id);
                                    }
                               }
                            }

                            var user = await _userManager.FindByEmailAsync(userAuthenticationData.EmailAddress);

                            var result = await _signInManager.PasswordSignInAsync(user, userAuthenticationData.Password, false, false);

                            return RedirectToAction("Welcome", "Account");
                        }
                    }
                    }else{
                        return PartialView("~/Views/Shared/_AlertMessage.cshtml", "Faça o registro primeiro !");
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