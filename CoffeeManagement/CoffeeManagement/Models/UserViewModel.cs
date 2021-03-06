﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeManagement.Models
{
    public class UserViewModel
    {
        public List<Employee> listEmployee;

        public List<Account> listAccount;

        public Employee employee;

        public Customer customer;

        public List<Customer> listCustomer;

        public List<Category> listCategory;

        public Category category;

        public List<Warehouse> listWarehouse;

        public Warehouse warehouse;

        public Promotion Promotion;

        public List<Promotion> listPromotion;

        public Timekeeping timekeeping;

        public List<Timekeeping> ListTimekeepings;

    }
}