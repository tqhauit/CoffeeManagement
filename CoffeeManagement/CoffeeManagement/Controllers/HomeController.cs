
using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
            db = new CoffeeShopDBEntities();
            List<Employee> employeeList = db.Employees.ToList();
            List<Account> accountList = db.Accounts.ToList();
            viewModel.listEmployee = employeeList;
            viewModel.listAccount = accountList;
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
            List<Promotion> promotionsList = db.Promotions.ToList();
            viewModel.listPromotion = promotionsList;
            return View(viewModel);
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

        [HttpPost]
        public ActionResult AddEmployee(string hovaten,string diachi,string ngaysinh,string sdt,string email,string mucluong,string chucvu,string matkhau)
        {
            try
            {
                db.Database.ExecuteSqlCommand("insert into Employee(Name,Birthday,Address,Tel,Email,Salary,Position) values(N'"+hovaten+"','"+ngaysinh+"',N'"+diachi+"','"+sdt+"','"+email+"','"+mucluong+"','"+chucvu+"')");
                Employee e = db.Employees.Where(x => x.Name == hovaten && x.Email == email && x.Position == chucvu).FirstOrDefault();
                db.Database.ExecuteSqlCommand("insert into Account values('"+e.EID+"','"+matkhau+"','1')");
                //Account newAccount = new Account();
                //newAccount.Username = db.Employees.Where(x => x.Email == e.Email).FirstOrDefault().EID;
                //newAccount.Password = matkhau;
                //db.Accounts.Add(newAccount);
                //db.SaveChanges();
                //Employee eCopy = db.Employees.Where(x => x.Email == e.Email).FirstOrDefault();
                //Account newAccount = new Account();
                //newAccount.Username = e.EID;
                //newAccount.Password = matkhau;
                //db.Accounts.Add(newAccount);
                //db.SaveChanges();
                return Json(new
                {
                    msg = "success"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    msg = ex.ToString()
                });
            }
        }

        public ActionResult DeleteEmployee(string id)
        {

            try
            {
                bool active;
                if (db.Accounts.Where(x => x.Username == id).FirstOrDefault().Status == true) {
                    db.Database.ExecuteSqlCommand("update Account set Status='0' where UserName='" + id + "'");
                    active = false;
                }
                else {
                    db.Database.ExecuteSqlCommand("update Account set Status='1' where UserName='" + id + "'");
                    active = true;
                }
                return Json(new
                {
                    msg = "success",
                    active,
                    id
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    msg = ex.ToString()
                });
            }
          
        }

        public ActionResult AddProduct(string tenloai,string mieuta)
        {
            try
            {
                db.Database.ExecuteSqlCommand("insert into Category(Name,Description) values(N'"+tenloai+"',N'"+mieuta+"')");
                return Json(new
                {
                    msg = "success",
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    msg = ex.ToString()
                });
            }
        }

        public ActionResult EditEmployee(string id,string chucvu,string hovaten,string diachi,string sdt,string mucluong)
        {
            try
            {
                db.Database.ExecuteSqlCommand("update Employee set Position='"+chucvu+"',Name=N'"+hovaten+"',Address=N'"+diachi+"',Tel='"+sdt+"',Salary='"+mucluong+"' where EID = '"+id+"'");
                return Json(new
                {
                    msg = "success"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    msg = ex.ToString()
                });
            }
        }
    }

}