using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using WebAPI.Services.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifetimesController : ControllerBase
    {
        private readonly ISingletonLifetimeService _singletonLifetimeService;
        private readonly ITransientLifetimeService _transientLifetimeService;
        private readonly IScopedLifetimeService _scopedLifetimeService;

        private readonly ISingletonLifetimeService _singletonLifetimeService2;
        private readonly ITransientLifetimeService _transientLifetimeService2;
        private readonly IScopedLifetimeService _scopedLifetimeService2;

        public LifetimesController(ISingletonLifetimeService singletonLifetimeService, ITransientLifetimeService transientLifetimeService, IScopedLifetimeService scopedLifetimeService, ISingletonLifetimeService singletonLifetimeService2, ITransientLifetimeService transientLifetimeService2, IScopedLifetimeService scopedLifetimeService2)
        {
            _singletonLifetimeService = singletonLifetimeService;
            _transientLifetimeService = transientLifetimeService;
            _scopedLifetimeService = scopedLifetimeService;
            _singletonLifetimeService2 = singletonLifetimeService2;
            _transientLifetimeService2 = transientLifetimeService2;
            _scopedLifetimeService2 = scopedLifetimeService2;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var result = @$"
            i.{_singletonLifetimeService.GetName()}
            i.{_singletonLifetimeService.GetName()}
            i.{_singletonLifetimeService2.GetName()}
            ii.{_transientLifetimeService.GetName()}
            ii.{_transientLifetimeService.GetName()}
            ii.{_transientLifetimeService2.GetName()}
            iii.{_scopedLifetimeService.GetName()}
            iii.{_scopedLifetimeService.GetName()}
            iii.{_scopedLifetimeService2.GetName()}
            ";
            return Ok(result);
        }
    }
}
