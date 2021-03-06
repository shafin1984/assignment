﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.Models.Models;
using MyMVCApp.Repository.Repository;

namespace MyMVCApp.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }
        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        public Customer GetByID(Customer customer)
        {
            return _customerRepository.GetByID(customer);
        }
    }
}
