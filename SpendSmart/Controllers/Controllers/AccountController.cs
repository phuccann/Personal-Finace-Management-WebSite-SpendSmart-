using System.Linq;
using System.Web.Mvc;
using SpendSmart.Models;

public class AccountController : Controller
{
    private SpendSmartDbContext db = new SpendSmartDbContext();

    // 1. Mở trang Đăng ký
    public ActionResult Register() { return View(); }

    // 2. Xử lý Đăng ký
    [HttpPost]
    public ActionResult Register(string Email, string Password)
    {
        db.Users.Add(new User { Email = Email, Password = Password, FullName = "User" });
        db.SaveChanges();
        return RedirectToAction("Login");
    }

    // 3. Mở trang Đăng nhập
    public ActionResult Login() { return View(); }

    // 4. Xử lý Đăng nhập
    [HttpPost]
    public ActionResult Login(string Email, string Password)
    {
        var u = db.Users.FirstOrDefault(x => x.Email == Email && x.Password == Password);
        if (u != null) return RedirectToAction("Index", "Dashboard");
        
        ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
        return View();
    }
}
