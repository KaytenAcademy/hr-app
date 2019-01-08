using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    class EmployeeDepartment :Entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string  Role { get; set; }

        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
