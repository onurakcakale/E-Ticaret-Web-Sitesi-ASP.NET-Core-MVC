using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        private Products products;
        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }

        public IActionResult Hizmetlerimiz()
        {
            return View();
        }

        public IActionResult WebTasarim()
        {
            return View();
        }

        public IActionResult WebYazilim()
        {
            return View();
        }

        public IActionResult Seo()
        {
            return View();
        }

        Context c = new Context();

        [Authorize]
        public IActionResult Sepet()
        {
            var degerler = c.products.ToList();
            return View(degerler);
        }

        public IActionResult Onay()
        {
            return View();
        }

        public IActionResult UrunSil(int id)
        {
            var deger = c.products.Find(id);
            c.products.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Sepet");
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order o)
        {
            c.orders.Add(o);
            var depa = c.products;
            c.products.RemoveRange(depa);
            c.SaveChanges();
            return Redirect("/Order/Onay/");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(Admin p)
        {
            var bilgiler = c.admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("/Home/Index/");
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View();
        }

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //public IActionResult Login(string Kullanici, string Sifre)
        //{
        //    var user = c.admins.FirstOrDefault(w => w.Kullanici.Equals(Kullanici) && w.Sifre.Equals(Sifre));
        //    if (user != null)
        //    {
        //        HttpContext.Session.SetInt32("adminID", user.AdminID);
        //        HttpContext.Session.SetString("Kullanici", user.Kullanici);
        //        return Redirect("/Home/Index/");
        //    }
        //    return Redirect("/Order/Login/");
        //}

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Admin a)
        {
            c.admins.Add(a);
            c.SaveChanges();
            return Redirect("/Home/Index/");
        }
    }
}