using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstApproach.Models
{
    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }
        [StringLength(150)]
        public string? FullName { get; set; }
        [StringLength(150)]
        public string? EmailAddress { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
