using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApsnetIdentityRoleBased.Controllers
{
    public class ProductController : Controller
    {
        [Authorize]
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
