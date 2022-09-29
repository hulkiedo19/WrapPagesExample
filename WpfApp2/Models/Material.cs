using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models
{
    [Table("Material")]
    public partial class Material
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Cost { get; set; }
        public string Image { get; set; } = null!;
        public int? MaterialTypeId { get; set; }

        [ForeignKey("MaterialTypeId")]
        [InverseProperty("Materials")]
        public virtual MaterialType? MaterialType { get; set; }
    }
}
