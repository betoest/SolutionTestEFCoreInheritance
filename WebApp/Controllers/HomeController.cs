using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IClientRepository _clientRepository;
        private readonly UserManager<AppUser> _userManager;



        public HomeController(IClientRepository clientRepository, UserManager<AppUser> userManager)
        {
            _clientRepository = clientRepository;
            _userManager = userManager;
        }



        public IActionResult Index()
        {
            var model = _clientRepository.GetAllClients();

            return View(model);
        }


        public IActionResult AddCliente()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddCliente(Cliente model)
        {
 
            if (ModelState.IsValid)
            {
                _clientRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }



        public IActionResult Details(string id)
        {
            var cliente = _clientRepository.GetClienteById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }


        [HttpGet]
        public IActionResult EmployeRegister()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> EmployeRegister(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                Empleado user = new Empleado
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.Phone,
                    Name = model.Name,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    HireDate = model.HireDate,
                    Job = model.Job,
                    Salary = model.Salary
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Passwd);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

    }
}
