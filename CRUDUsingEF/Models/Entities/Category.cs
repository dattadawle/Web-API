using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDUsingEF.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
    }
}