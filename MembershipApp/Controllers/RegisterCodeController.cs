using MembershipApp.Extensions;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MembershipApp.Controllers
{
    public class RegisterCodeController : Controller
    {
        public async Task<ActionResult> Register(string code)
        {
            if (Request.IsAuthenticated)
            {
                var userId = HttpContext.GetUserId();

                var register = await SubscriptionExtensions.RegisterUserSubscriptionCode(userId, code);

                if (!register) throw new ApplicationException();

                return PartialView("_RegisterCodePartial");
            }
            return View();
        }
    }
}