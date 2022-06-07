using Microsoft.AspNetCore.Mvc;
using Paginaweb1.Models;

namespace Paginaweb1.Controllers
{
    public class ContactosController : Controller
    {
        List<DatosContacto> datos = new List<DatosContacto>()
        {
            new DatosContacto(){ Correo ="rmonge@ui.edu",
                Nombre="Ricardo" },
            new DatosContacto(){ Correo ="Karim@ui.edu",
                Nombre="Karim" },
            new DatosContacto(){ Correo = "fabio@ui.edu",
                Nombre="fabiola" },



        };
        public IActionResult Index()
        {
            return View(datos);
        }
    }
}
