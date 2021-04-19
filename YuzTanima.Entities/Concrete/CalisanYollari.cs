using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YuzTanima.Core.Entities.Abstract;

namespace YuzTanima.Entities.Concrete
{
    public class CalisanYollari : IEntity
    {
        [Key]
        public int calisanYollariId { get; set; }
        public int calisanId { get; set; }
        public int kameraId { get; set; }
        public int siraNo { get; set; }
    }
}
