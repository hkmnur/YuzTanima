using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YuzTanima.Core.Entities.Abstract;

namespace YuzTanima.Entities.Concrete
{
    public class KayitliOlmayanZiyaretciler : IEntity
    {
        [Key]
        public int kayitliOlmayanZiyaretciId { get; set; }
        public string ziyaretci { get; set; }
        public int kameraId { get; set; }
        public DateTime zaman { get; set; }
    }
}
