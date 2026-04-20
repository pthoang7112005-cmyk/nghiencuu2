using Microsoft.AspNetCore.Mvc;

namespace nghiencuu2.Controllers
{
    public class hom1Controller : Controller
    {
        // Action a1 sẽ tương ứng với đường dẫn /hom1/a1
        public IActionResult a1()
        {
            // Lệnh này sẽ tự động tìm file a1.cshtml trong thư mục Views/hom1/
            return View();
        }
    }
}