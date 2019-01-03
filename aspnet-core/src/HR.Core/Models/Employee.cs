using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models
{
   public class Employee: Entity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual List<EmployeeDepartmen> EmployeeDepartmen { get; set; }


    }
}
