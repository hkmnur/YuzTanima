using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuzTanima.Business.Abstract;
using YuzTanima.Entities.Concrete;

namespace YuzTanima.WebService.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class RaporController : ControllerBase
    {
        private IRaporlarService _raporlarService;

        public RaporController(IRaporlarService raporlarService)
        {
            _raporlarService = raporlarService;
        }

        [HttpPost("add")]
        public IActionResult Add(Raporlar rapor)
        {
            var result = _raporlarService.Add(rapor);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}