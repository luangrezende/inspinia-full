using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Portal.Road.Controllers
{
    public class ConfiguracoesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["SubTitle"] = "Página de configuração do sistema";
            ViewData["Message"] = "Todas as alterações deverão ser feitas por um usuário com permissões de Administrador";

            return View();
        }
    }
}
