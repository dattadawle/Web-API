using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_EF.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }


        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
    }
}