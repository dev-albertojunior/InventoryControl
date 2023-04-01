using InventoryControl.Models;
using InventoryControl.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryControl.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
               // try
               // {      
                    await _userRepository.CreateUser(user);

                    return RedirectToAction(nameof(Index));
               // }
               // catch (Exception ex)
               // {
                    ModelState.AddModelError("", "Não foi possível salvar as informações no banco de dados. Tente novamente mais tarde.");

                    return View(user);
               // }
            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult RecoverPassword()
        {
            return View();
        }
    }
}
