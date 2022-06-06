using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Lütfen Ülkenizi Giriniz.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Lütfen Şehrinizi Giriniz.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Lütfen İlçenizi Giriniz.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz.")]
        public string Zip { get; set; }
        public bool Shipped { get; set; }
    }
}