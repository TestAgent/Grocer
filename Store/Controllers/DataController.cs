using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Store.Data;
using Store.Infrastructure.Providers;

namespace Store.Controllers {
    [Route("api/v1/[Controller]")]
    public class DataController : Controller {
        private readonly IStoreProvider Provider;

        public DataController(IStoreProvider provider) {
            Provider = provider;
        }

        [HttpGet("gds")]
        public async Task<IActionResult> GetGds() {
            throw new NotImplementedException();
        }
    }
}
