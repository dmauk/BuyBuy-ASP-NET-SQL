using BuyBuy.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace BuyBuy.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> {
                new Customer { Name = "Bob Bob", Id = 2 },
                new Customer { Name = "Richard Richar", Id = 1}
            };
        }
    }
}