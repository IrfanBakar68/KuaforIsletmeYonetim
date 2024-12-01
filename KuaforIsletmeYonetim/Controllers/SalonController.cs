using Microsoft.AspNetCore.Mvc;
using KuaforIsletmeYonetim.Models;

namespace KuaforIsletmeYonetim.Controllers
{
    public class SalonController : Controller
    {
        private readonly KuaforContext _context;

        public SalonController(KuaforContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddSalon()
        {
            var yeniSalon = new Salon
            {
                Ad = "Kuaför A",
                Adres = "Adres A",
                Telefon = "0123456789"
            };

            _context.Salonlar?.Add(yeniSalon);
            _context.SaveChanges();

            return Ok("Salon başarıyla eklendi!");
        }
    }
}
