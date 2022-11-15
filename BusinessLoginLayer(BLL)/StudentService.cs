
using BusinessLoginLayer_BLL_.DTO;
using DataAccessLayer_DAL_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLoginLayer_BLL_
{
    public class StudentService
    {
        public static List<StudentDTO> Get() //StudentDTO must be public
        {
            var students = new List<StudentDTO>();
     
            foreach(var item in StudentRepo.Get())
            {
                students.Add(new StudentDTO() { ID = item.ID, Name = item.Name });
            }
            return students;
          
        }
    }
}
