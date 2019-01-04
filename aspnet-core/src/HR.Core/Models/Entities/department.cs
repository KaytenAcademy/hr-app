using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    
        public class department : Entities.entity
        {
            public string Name { get; set; }

            //Navigation 
            public ICollection<employeeDepartment> employees { get; set; }
            public company Company { get; set; }
        }
    
}
