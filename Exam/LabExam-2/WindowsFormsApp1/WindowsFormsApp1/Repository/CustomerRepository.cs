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
        SqlDataReader dreader;

        public int InsertCustomer(Customer customer)
        {
                sqlConnection = new SqlConnection(connectionString);
                int isExecuted;
                commandString = @"insert into Customers(customerName, email, accountNumber, openingDate)values('" + customer.customerName + "', '" + customer.email + "', '" + customer.accountNumber + "', '" + customer.openingDate + "')";
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
        public int DepositBalance(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"UPDATE Customers SET balance = balance + "+customer.balance+" WHERE accountNumber = '"+customer.accountNumber+"'"; 
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
        public int CheckBalance(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"select balance from Customers where accountNumber='"+customer.accountNumber+"';";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            int bal=0;
            sqlConnection.Open();
            dreader = sqlCommand.ExecuteReader();
            if (dreader.Read()) { bal = Convert.ToInt32(dreader[0]); }
            sqlConnection.Close();
            return bal;
        }
        public int WithdrawBalance(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"UPDATE Customers SET balance = balance - " + customer.balance + " WHERE accountNumber = '" + customer.accountNumber + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
        public DataTable Display(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"select * from Customers where accountNumber='"+customer.accountNumber+"';";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
    
}
