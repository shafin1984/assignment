using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Models;
using BankApp.BusinessLogicLayer;

namespace BankApp.BusinessLogicLayer
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public int InsertCustomer(Customer customer)
        {
            return _customerRepository.InsertCustomer(customer);
        }
        public bool isExist(Customer customer)
        {
            return _customerRepository.isExist(customer);
        }
    }
    
}
