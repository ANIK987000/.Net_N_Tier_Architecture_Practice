//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer_DAL_.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Courses = new HashSet<Cours>();
            this.Students = new HashSet<Student>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual Department Departments1 { get; set; }
        public virtual Department Department1 { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}