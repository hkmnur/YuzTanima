using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YuzTanima.Core.Entities.Abstract;

namespace YuzTanima.Entities.Concrete
{
    public class KayitliZiyaretciler : IEntity
    {
        [Key]
        public int kayitliZiyaretciId { get; set; }
        public int ziyaretciId { get; set; }
        public int kameraId { get; set; }
        public DateTime zaman { get; set; }
    }
}
