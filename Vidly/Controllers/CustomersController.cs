using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // Properly dispose object when done
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            // LINQ - get customers
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        // GET: Customers/Details/{id}
        public ActionResult Details(int? Id)
        {
            // Use LINQ + lambda to find customer in list with matching Id, include MembershipType data
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);

        }
    }
}