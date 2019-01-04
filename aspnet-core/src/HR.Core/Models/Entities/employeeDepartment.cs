using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class employeeDepartment : Entities.entity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Role { get; set; }

        public employee employee { get; set; }
        public department Department { get; set; }
    }
}
