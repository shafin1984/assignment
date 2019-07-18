using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibApp.Models.Models;
using LibApp.Repository;
using System.Data;

namespace LibApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
            
        public int AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
        public DataTable Display()
        {
            return _studentRepository.Display();
        }
    }
}
