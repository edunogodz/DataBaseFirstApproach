using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstApproach.Models
{
    public partial class City
    {
        [Key]
        [Column("CityID")]
        public int CityId { get; set; }
        [StringLength(100)]
        public string CityName { get; set; } = null!;
        [StringLength(100)]
        public string Country { get; set; } = null!;
        [StringLength(100)]
        public string? State { get; set; }
    }
}
