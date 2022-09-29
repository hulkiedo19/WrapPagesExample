using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models
{
    [Keyless]
    [Table("ProductMaterial")]
    public partial class ProductMaterial
    {
        public int? ProductId { get; set; }
        public int? MaterialId { get; set; }
        public int Count { get; set; }

        [ForeignKey("MaterialId")]
        public virtual Material? Material { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}
