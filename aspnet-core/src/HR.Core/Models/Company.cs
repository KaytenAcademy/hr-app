using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models
{
   public class Company: Entity
    {

        public string Name { get; set; }

        public virtual List<Departman> Departman { get; set; }

    }
}
