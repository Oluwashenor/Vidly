using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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
            var customers = _context.Customers.ToList();
            //var customers = GetCustomers();

            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
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