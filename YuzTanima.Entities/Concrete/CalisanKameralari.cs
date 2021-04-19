using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YuzTanima.Core.Entities.Abstract;

namespace YuzTanima.Entities.Concrete
{
    public class CalisanKameralari : IEntity
    {
        [Key]
        public int calisanKameralariId { get; set; }
        public int calisanId { get; set; }
        public int kameraId { get; set; }
    }
}
