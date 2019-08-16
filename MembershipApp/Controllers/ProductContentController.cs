using MembershipApp.Extensions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MembershipApp.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
            var setions = await SectionExtensions.GetProductSectionsAsync(id, userId);
            return View(setions);
        }

        public async Task<ActionResult> Content(int productId, int itemId)
        {
            var model = await SectionExtensions.GetContentAsync(productId, itemId);
            return View("Content", model);
        }
    }
}