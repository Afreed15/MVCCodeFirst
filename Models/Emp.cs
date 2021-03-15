using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppexegit.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        public  int Empid { get; set; }
        public string EmpName { get; set; }
        public string  Designation { get; set; }
        public DateTime? EDoj { get; set; }
    }
}