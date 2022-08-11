using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delete_record.Models
{
    public class Class1
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string DepartmentName { get; set; }
    }

}