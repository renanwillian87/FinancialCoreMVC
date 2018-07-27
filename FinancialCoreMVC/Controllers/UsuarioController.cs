using Microsoft.AspNetCore.Mvc;
using FinancialCoreMVC.Models;

namespace FinancialCoreMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if(login == true)
            {
                return RedirectToAction("Index", "Home");
            }
            TempData["MensagemLoginInvalido"] = "Dados do login inválidos";
            return RedirectToAction("Login");
        }
    }
}