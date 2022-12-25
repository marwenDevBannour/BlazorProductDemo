using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCategory.Models.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        [ForeignKey("FkCartId")]
        public int CartId { get; set; }
        [ForeignKey("FkProductId")]
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}

