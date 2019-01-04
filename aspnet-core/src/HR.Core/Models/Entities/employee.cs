using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Models.Entities
{
    public class employee : Entities.entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //Navigation 
        public ICollection<employeeDepartment> Departments { get; set; }

        public void Hire(DateTime Start, DateTime End, string Role)
        {

        }
        public void Fire(int id)
        {

        }

    }
}
