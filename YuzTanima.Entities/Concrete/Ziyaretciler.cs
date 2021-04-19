using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YuzTanima.Core.Entities.Abstract;

namespace YuzTanima.Entities.Concrete
{
    public class Ziyaretciler : IEntity
    {
        [Key]
        public int ziyaretciId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public string resimUrl { get; set; }
        public int calisanId { get; set; }
    }
}
