using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirstApproach.Models
{
    public partial class User
    {
        [Key]
        [Column("UserID")]
        [StringLength(3)]
        [Unicode(false)]
        [Required(ErrorMessage = "Code is Required")]      
        [RegularExpression(@"^[a-zA-Z'\s]{1,3}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string UserId { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string UserName { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string? Email { get; set; }
    }
}
