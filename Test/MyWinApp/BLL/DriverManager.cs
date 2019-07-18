using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;
using MyWinApp.Repository;

namespace MyWinApp.BLL
{
    public class DriverManager
    {
        DriverRepository _driverRepository = new DriverRepository();
        public DataTable LoadLevel()
        {
            return _driverRepository.LoadLevel();
        }

        public DataTable ShowDrivers()
        {
            return _driverRepository.ShowDrivers();
        }

        public int InsertDriver(Driver driver)
        {
            return _driverRepository.InsertDriver(driver);
        }
        public DataTable SearchDrivers(Driver driver)
        {
            return _driverRepository.SearchDrivers(driver);
        }
        public int UpdateDriver(Driver driver)
        {
            return _driverRepository.UpdateDriver(driver);
        }
        public bool isExist(Driver driver)
        {
            return _driverRepository.isExist(driver);
        }
    }
}
