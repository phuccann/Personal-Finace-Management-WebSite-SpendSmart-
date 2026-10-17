using System;
using System.Linq;
using System.Web.Mvc;
using SpendSmart.Models;

namespace SpendSmart.Controllers
{
    public class DefaultController : Controller
    {
        private SpendSmartDBEntities1 db = new SpendSmartDBEntities1();

        // 1. Trang Tổng quan
        public ActionResult Index()
        {
            var data = db.Transactions.ToList();
            return View(data);
        }

        // 2. Trang Giao dịch
        public ActionResult Transactions()
        {
            var data = db.Transactions.ToList();
            return View(data);
        }

        // 3. Trang Tuần
        public ActionResult Weekly()
        {
            var data = db.Transactions.ToList();
            return View(data);
        }

        // 4. Trang Tích lũy
        public ActionResult Savings()
        {
            var data = db.Savings.ToList();
            return View(data);
        }

        // 5. Trang Gửi tiền
        public ActionResult DepositSavings()
        {
            var data = db.Savings.ToList();
            return View(data);
        }

        // 6. Trang Ngân sách
        public ActionResult Budgets()
        {
            var data = db.Budgets.ToList();
            return View(data);
        }

        // 7. Trang Thống kê
        public ActionResult Analytics()
        {
            var data = db.sp_GetAnalyticsCategory(1, "2026-10").ToList();
            return View(data);
        }

        // 8. Các trang Đăng nhập / Đăng ký
        public ActionResult Login() { return View(); }
        public ActionResult Register() { return View(); }
        public ActionResult GoogleLogin() { return View(); }
    }
}