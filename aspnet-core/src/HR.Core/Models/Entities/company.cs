using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class company:Entities.entity
    {
        public string Name { get; set; }

        //Navigation
        public ICollection<department> departments { get; set; }
    }
}
