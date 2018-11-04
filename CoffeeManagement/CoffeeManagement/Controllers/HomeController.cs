
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
        CoffeeShopDBEntities db = new CoffeeShopDBEntities();

        UserViewModel viewModel = new UserViewModel();
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
           
            List<Employee> employeeList = db.Employees.ToList();
            viewModel.listEmployee = employeeList;
            return View(viewModel);
        }

        public ActionResult QuanLyKhachHang()
        {

            List<Customer> customerList = db.Customers.ToList();
            viewModel.listCustomer = customerList;
            return View(viewModel);
        }

        public ActionResult QuanLyLoaiSP()
        {
            
            List<Category> categoriesList = db.Categories.ToList();
            viewModel.listCategory = categoriesList;
            return View(viewModel);
        }

        public ActionResult QuanLyKho()
        {
            List<Warehouse> warehousesList = db.Warehouses.ToList();
            viewModel.listWarehouse = warehousesList;
            return View(viewModel);
        }

        public ActionResult QuanLyMenu()
        {
            return View("QuanLyMenu");
        }

        public ActionResult QuanLyVoucher()
        {
            return View("QuanLyVoucher");
        }

        public ActionResult QuanLyBan()
        {
            return View("QuanLyBan");
        }

        public ActionResult QuanLyNVTongQuan()
        {
            return View("QuanLyNVTongQuan");
        }

        public ActionResult QuanLyAllHoaDon()
        {
            return View("QuanLyAllHoaDon");
        }

        public ActionResult QuanLyTaoHoaDon()
        {
            return View("QuanLyTaoHoaDon");
        }

        public ActionResult QuanLyThanhToan()
        {
            return View("QuanLyThanhToan");
        }

        public ActionResult QuanLyPCTongQuan()
        {
            return View("QuanLyPCTongQuan");
        }

        public ActionResult QuanLyPCDaTiepNhan()
        {
            return View("QuanLyPCDaTiepNhan");
        }

        public ActionResult QuanLyPCSanPhamHet()
        {
            return View("QuanLyPCSanPhamHet");
        }

        public ActionResult QuanLyLichLamSapXep()
        {
            return View("QuanLyLichLamSapXep");
        }
        
        public ActionResult QuanLyLichLamChinhSua()
        {
            return View("QuanLyLichLamChinhSua");
        }
    }
}