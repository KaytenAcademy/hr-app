using Microsoft.AspNetCore.Antiforgery;
using HR.Controllers;

namespace HR.Web.Host.Controllers
{
    public class AntiForgeryController : HRControllerBase
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
