using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    class Employee :Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual IEnumerable<EmployeeDepartment> EmployeeDepartments { get; set; }

        public void Hire(DateTime Start, DateTime End, string Role)
        {
        }
        public void Fire(int EmployeeId)
        {
        }
    }
}
