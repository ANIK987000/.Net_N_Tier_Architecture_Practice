using DataAccessLayer_DAL_.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL_
{
    public class StudentRepo
    {
        public static List<Student> Get()
        {
            var db = new UMS_DBEntities();
            return db.Students.ToList();
        }
    }
}
