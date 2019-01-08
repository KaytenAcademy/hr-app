using System.Collections.Generic;

namespace HR.Models.Entities
{
    class Department:Entity
    {
        public string Name { get; set; }

        public Company Company { get; set; }
        public virtual IEnumerable<EmployeeDepartment> EmployeeDeparments { get; set; }
    }
}