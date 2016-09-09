using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntityFramework.Repository;
using System.Data.Entity;

namespace MvcEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities _dbContext = new NorthwindEntities();

        // GET: Home
        public ActionResult Index()
        {
            var customers = (from c in _dbContext.Customers
                             select c).ToList();
            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                //Northwind requires a key to be set (bad idea!!)
                customer.CustomerID = "mykey";
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Edit(string id)
        {
            var customer = (from c in _dbContext.Customers
                            where c.CustomerID == id
                            select c).SingleOrDefault();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                //Update customer
                _dbContext.Customers.Attach(customer);
                _dbContext.Entry(customer).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Details(string id)
        {
            var customer = (from c in _dbContext.Customers
                            where c.CustomerID == id
                            select c).SingleOrDefault();
            return View(customer);
        }

        public ActionResult Delete(string id)
        {
            var customer = (from c in _dbContext.Customers
                            where c.CustomerID == id
                            select c).SingleOrDefault();
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(string id)
        {
            var customer = _dbContext.Customers.Find(id);
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}