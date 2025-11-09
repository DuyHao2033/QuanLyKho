using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QUANLYKHO.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Nhân viên,Sales")]
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
