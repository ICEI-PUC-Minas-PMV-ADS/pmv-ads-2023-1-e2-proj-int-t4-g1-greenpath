﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GP23.Models;
using GP23.Data;
using GP23.Interfaces;
using GP23.ViewModels;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Globalization;
using System.Net;
using System.Runtime;
using GP23.Helpers;

namespace GP23.Controllers;

    public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ILocationService _locationService;

    public HomeController(ILogger<HomeController> logger,
        UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ILocationService locationService)
    {
        _logger = logger;
        //_vagasRepository = vagasRepository;
        _userManager = userManager;
        _signInManager = signInManager;
        _locationService = locationService;
    }

    public async Task<IActionResult> Index()
    {
        var ipInfo = new IPInfo();
        var homeViewModel = new HomeViewModel();
        try
        {
            string url = "https://ipinfo.io?token=63d5ada815b74c";
            var info = new WebClient().DownloadString(url);
            ipInfo = JsonConvert.DeserializeObject<IPInfo>(info);
            RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
            ipInfo.Country = myRI1.EnglishName;
            homeViewModel.City = ipInfo.City;
            homeViewModel.State = ipInfo.Region;
            if (homeViewModel.City != null)
            {
                //homeViewModel.Vagas = await _vagasRepository.GetVagasByCity(homeViewModel.City);
            }
            return View(homeViewModel);
        }
        catch (Exception)
        {
            //homeViewModel.Vagas = null;
        }

        return View(homeViewModel);
    }

    public IActionResult Register()
    {
        var response = new HomeUserCreateViewModel();
        return View(response);
    }

    [HttpPost]
    public async Task<IActionResult> Index(HomeViewModel homeVM)
    {
        var createVM = homeVM.Register;

        if (!ModelState.IsValid) return View(homeVM);

        var user = await _userManager.FindByEmailAsync(createVM.Email);
        if (user != null)
        {
            ModelState.AddModelError("Register.Email", "Este endereço de email já foi usado.");
            return View(homeVM);
        }

        var userLocation = await _locationService.GetCityByZipCode(createVM.ZipCode ?? 0);

        if (userLocation == null)
        {
            ModelState.AddModelError("Register.ZipCode", "Não foi possível encontrar o código postal.");
            return View(homeVM);
        }

        var newUser = new AppUser
        {
            UserName = createVM.UserName,
            Email = createVM.Email,
            Address = new Address()
            {
                State = userLocation.StateCode,
                City = userLocation.CityName,
                ZipCode = createVM.ZipCode ?? 0,
            }
        };

        var newUserResponse = await _userManager.CreateAsync(newUser, createVM.Password);

        if (newUserResponse.Succeeded)
        {
            await _signInManager.SignInAsync(newUser, isPersistent: false);
            await _userManager.AddToRoleAsync(newUser, UserRoles.User);
        }
        return RedirectToAction("Index", "User");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

