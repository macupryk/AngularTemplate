using Microsoft.AspNetCore.Antiforgery;
using AngularProject.Controllers;

namespace AngularProject.Web.Host.Controllers
{
    public class AntiForgeryController : AngularProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
