using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeManagement.Controllers
{
    public class HomeController : AuthorizeController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuanLyTongQuan()
        {
            return View();
        }

        public ActionResult QuanLyNhanVien()
        {
            CoffeeShopDBEntities db = new CoffeeShopDBEntities();
            List<Employee> employeeList = db.Employees.ToList();
            return View(employeeList);
        }

        public ActionResult QuanLyKhachHang()
        {
            CoffeeShopDBEntities db = new CoffeeShopDBEntities();
            List<Customer> customerList = db.Customers.ToList();
            return View(customerList);
        }
    }
}