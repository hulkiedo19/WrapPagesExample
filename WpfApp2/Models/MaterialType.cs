using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models
{
    [Table("MaterialType")]
    public partial class MaterialType
    {
        public MaterialType()
        {
            Materials = new HashSet<Material>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        [InverseProperty("MaterialType")]
        public virtual ICollection<Material> Materials { get; set; }
    }
}
