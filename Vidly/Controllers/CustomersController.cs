﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            //var customers = GetCustomers();

            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Detail(int id)
        {
            var customers = _context.Customers.ToList();
            foreach (var customer in customers)
            {
                if(customer.Id == id)
                {
                    return View(customer);
                }
            }
            return HttpNotFound();
           
        }

        public List<Customer> GetCustomers() {
            var customers = new List<Customer>
            {
                new Customer {
                    Name="Adeshina"
                },
                new Customer {
                    Name="Kelechukwu"
                }
            };
            return customers;
        }
    }
}