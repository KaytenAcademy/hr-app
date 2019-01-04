using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HR.Models.Interfaces
{
    public interface IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ID { get; set; }
    }
}
