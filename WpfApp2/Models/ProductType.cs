using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models
{
    [Table("ProductType")]
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        [InverseProperty("ProductType")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
