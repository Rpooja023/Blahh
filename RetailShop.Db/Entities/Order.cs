using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Db.Entities

{
    public class Order
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public Guid ProdutId { get; set; }
        [ForeignKey(nameof(ProdutId))]
        public Product Product { get; set; }
        
    }
}
