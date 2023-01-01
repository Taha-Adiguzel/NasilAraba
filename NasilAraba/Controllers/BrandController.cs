using Microsoft.AspNetCore.Mvc;
using NasilAraba.Models;

namespace NasilAraba.Controllers
{
    public class BrandController : Controller
    {
        GalleryContext g= new GalleryContext();
        public IActionResult Index()
        {
            var Brands = g.Brands;
            return View(Brands);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrateBrand(Brand b)
        {
            if (ModelState.IsValid)
            {
                g.Add(b);
                g.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["hata"] = "Lütfen Gerekli alanları doldurunuz";
                return RedirectToAction("CreateBrand");
            }
        }
    }
}
