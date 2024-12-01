using Microsoft.AspNetCore.Mvc;
using KuaforIsletmeYonetim.Models;
using Microsoft.EntityFrameworkCore;

namespace KuaforIsletmeYonetim.Controllers
{
    public class RandevuController : Controller
    {
        private readonly KuaforContext _context;

        public RandevuController(KuaforContext context)
        {
            _context = context;
        }

        // GET: Randevuların listesi
        public IActionResult Index()
        {
            // Randevuların listesini, Çalışan ilişkisiyle birlikte yükle
            var randevular = _context.Randevular?
                .Include(r => r.Calisan)
                .ToList() ?? new List<Randevu>(); // Null durumunda boş liste döndür
            return View(randevular);
        }

        // GET: Yeni Randevu Sayfası
        public IActionResult Yeni()
        {
            return View();
        }

        // POST: Yeni Randevu Ekleme
        [HttpPost]
        public IActionResult Yeni(Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Randevular?.Add(randevu); // Randevuyu veri tabanına ekle
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(randevu);
        }
    }
}
