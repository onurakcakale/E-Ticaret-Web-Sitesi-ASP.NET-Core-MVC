using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public List<Products> Lines { get; set; } = new List<Products>();

        Context c = new Context();
        public IActionResult Urunler()
        {
            var degerler = c.products.ToList();
            return View(degerler);
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Cicek()
        {
            return View();
        }

        public IActionResult Danismanlik()
        {
            return View();
        }

        public IActionResult Gida()
        {
            return View();
        }

        public IActionResult Insaat()
        {
            return View();
        }

        public IActionResult Is()
        {
            return View();
        }

        public IActionResult Otomotiv()
        {
            return View();
        }

        public IActionResult Saglik()
        {
            return View();
        }

        public IActionResult Sigorta()
        {
            return View();
        }

        public IActionResult Temizlik()
        {
            return View();
        }

        public IActionResult Turizm()
        {
            return View();
        }

        public async Task<ActionResult> Ekle(Products model)
        {
            await c.AddAsync(model);
            await c.SaveChangesAsync();
            return Redirect("/Order/Sepet");
        }
    }
}