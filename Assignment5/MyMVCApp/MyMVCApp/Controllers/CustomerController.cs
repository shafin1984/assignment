using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager =new CustomerManager();
        private Customer _customer = new Customer();
        
        // GET: Student
        public ActionResult Add()
        {
           
            _customer.Name = "Gaus";
            _customerManager.Add(_customer);

            return View();
        }
        public ActionResult Delete()
        {
            _customer.ID = 1;
            
            _customerManager.Delete(_customer);

            return View();
        }

        public ActionResult Update()
        {
            _customer.ID = 6;
            //Method 1
            //_student.Name = "Kamal";
            //_studentManager.Update(_student);

            //Method 2
            Customer aCustomer = _customerManager.GetByID(_customer);
            if (aCustomer != null)
            {
                aCustomer.Name = "Ridoy";
                _customerManager.Update(aCustomer);
            }

            return View();
        }
        public ActionResult GetByID()
        {
            _customer.ID = 3;
            
            Customer bCustomer = _customerManager.GetByID(_customer);

            return View();
        }
        public ActionResult GetAll()
        {
            

            List<Customer> bCustomer = _customerManager.GetAll();

            return View();
        }
    }
}