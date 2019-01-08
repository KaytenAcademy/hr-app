using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    class Company:Entity
    {
        public string Name { get; set; }
        public virtual IEnumerable<Department> Deparments { get; set; }
    }
}
