using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BankApp.BusinessLogicLayer;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repository
{
    public class CustomerRepository
    {
        public string connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=Bank; Integrated Security=true";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string commandString;

        public int InsertCustomer(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            int isExecuted;
            commandString = @"insert into Customers(customerName, email, accountNumber, openingDate)values('"+customer.customerName+"', '"+customer.email+"', '"+customer.accountNumber+"', '"+customer.openingDate+"')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }
        public bool isExist(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            bool isExist = false;
            commandString = @"SELECT count(*) FROM Customers WHERE accountNumber='" + customer.accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = (int)sqlCommand.ExecuteScalar();
            if (isExecuted == 0) { isExist = true; }
            sqlConnection.Close();
            return isExist;
        }
        public int UpdateBalance(Customer customer)
        {
            commandString = @"UPDATE Customers SET balance=" + customer.balance + " + WHERE accountNumber='" + customer.accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
    }
    
}
