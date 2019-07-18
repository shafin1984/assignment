using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibApp.Models.Models;
using System.Data.SqlClient;
using System.Data;

namespace LibApp.Repository
{
    public class StudentRepository
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        String connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=Student; Integrated Security = true";
        string command;
        public int AddStudent(Student student)
        {
            command = @"insert into Students values ('"+student.ID+"', '"+student.Name+"', '"+student.Roll+"', '"+student.Address+"',"+student.Contact+")";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            int executed=sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return executed;
        }
        public DataTable Display()
        {
            command = @"select * from Students";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(command, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
