using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string customerName { get; set; }
        public string email { get; set; }
        public string accountNumber { get; set; }
        public string openingDate { get; set; }
        public int balance { get; set; }
    }
}
