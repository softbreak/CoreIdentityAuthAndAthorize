using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreIdentityAuthAndAthorize.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestAction()
        {
            return View();
        }
    }
}
