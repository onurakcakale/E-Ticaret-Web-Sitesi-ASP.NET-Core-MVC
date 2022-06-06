using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Admin
    {
        internal object admins;

        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Kullanici { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Sifre { get; set; }
    }
}