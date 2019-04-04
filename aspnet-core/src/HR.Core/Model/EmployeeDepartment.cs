using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Model
{
    class EmployeeDepartment:Entity
    {
        public string role { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        //Navigation
        public Employee Employees { get; set; }
        public Department Departments { get; set; }
    }
}
