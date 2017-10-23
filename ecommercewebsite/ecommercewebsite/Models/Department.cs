using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ecommercewebsite.Models
{
    public class Department
    {
        [Key]
        public int DpeartmentId { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]
        [MaxLength(50, ErrorMessage ="The field {0} must be maximum {1} characters Length")]
        [Display(Name= "Department")]
        [Index("Department_Name_Index", IsUnique = true)]
        public string name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}