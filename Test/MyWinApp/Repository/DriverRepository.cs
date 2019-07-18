using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;

namespace MyWinApp.Repository
{
    public class DriverRepository
    {
        string connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=DriverDB; Integrated Security=True";
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        public DataTable LoadLevel()
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Levels";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    districtComboBox.DataSource = dataTable;

            sqlConnection.Close();
            return dataTable;
        }

        public DataTable ShowDrivers()
        {
            commandString = @"SELECT * FROM DriversView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable SearchDrivers(Driver driver)
        {
            commandString = @"SELECT * FROM DriversView WHERE LicenseNo LIKE '%"+driver.LicenseNo+"%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public int InsertDriver(Driver driver)
        {
            commandString = @"INSERT INTO Drivers (LicenseNo, Name, Age, Address, LevelID) VALUES ('" + driver.LicenseNo + "', '" + driver.Name + "', " + driver.Age + ", '" + driver.Address + "'," + driver.LevelID + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            
            sqlConnection.Close();

            return isExecuted;
        }

        public int UpdateDriver(Driver driver)
        {
            commandString = @"UPDATE Drivers SET Name='"+driver.Name+"', Age="+driver.Age+", Address='"+driver.Address+"', LevelID="+ driver.LevelID + " WHERE LicenseNo='"+driver.LicenseNo+"'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
        public bool isExist(Driver driver)
        {
            bool isExist = false;
            commandString = @"SELECT count(*) FROM DriversView WHERE LicenseNo='" + driver.LicenseNo + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted =(int)sqlCommand.ExecuteScalar();
            if (isExecuted == 0) { isExist = true; }
            sqlConnection.Close();
            return isExist;
        }
    }
}
