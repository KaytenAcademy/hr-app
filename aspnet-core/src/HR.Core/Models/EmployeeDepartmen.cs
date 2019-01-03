using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models
{
   public class EmployeeDepartmen :Entity
    {

        public string Rol { get; set; }

        public string Surname { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Departman Departman { get; set; }


    }
}
