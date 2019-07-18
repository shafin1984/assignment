using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.DatabaseContext.DatabaseContext;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Repository.Repository
{
    public class CustomerRepository
    {
        CustomerDBContext db = new CustomerDBContext();
        public bool Add(Customer customer)
        {
            int isExecuted = 0;
            db.Customers.Add(customer);
            isExecuted=db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Customer customer)
        {
            int isExecuted = 0;
            Customer aCustomer = db.Customers.FirstOrDefault(c=>c.ID==customer.ID);
            if(aCustomer != null)
            {
                db.Customers.Remove(aCustomer);
                isExecuted = db.SaveChanges();
            }
            
            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Customer customer)
        {
            int isExecuted = 0;
            //Method 1
            //Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (aStudent != null)
            //{
            //    aStudent.Name = student.Name;
            //    isExecuted = db.SaveChanges();
            //}


            //Method 2
            db.Entry(customer).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public List<Customer> GetAll()
        {
           
            return db.Customers.ToList();
        }
        public Customer GetByID(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.ID == customer.ID);
            return aCustomer;
        }
    }
}
