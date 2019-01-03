using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models
{
   public class Departman: Entity
    {
        public string Name { get; set; }

        public virtual List<EmployeeDepartmen> EmployeeDepartmen { get; set; }


        public virtual Company Company { get; set; }
    }
}
