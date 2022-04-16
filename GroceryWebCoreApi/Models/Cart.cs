﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryWebCoreApi.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }    

        [Required]
        public int PurchasedQty { get; set; }

        [Required]
        public int SubTotalPrice { get; set; }

        [Required]
        public bool IsOrdered { get; set; }

        

    }
}
