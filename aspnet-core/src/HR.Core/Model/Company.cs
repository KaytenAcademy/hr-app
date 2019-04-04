using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Model
{
    class Company:Entity
    {
        public string Name { get; set; }
        // Navigation //when company dies so does department 
        public ICollection<Department> Departments { get; set; }
    }
}
