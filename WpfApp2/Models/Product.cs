using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int ArticleNumber { get; set; }
        public int MinCost { get; set; }
        public int? ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        [InverseProperty("Products")]
        public virtual ProductType? ProductType { get; set; }
    }
}
