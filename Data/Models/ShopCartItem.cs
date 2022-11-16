using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class ShopCartItem
    {
        [Key]
        public int itemId {get;set;}
        public Car car { get; set; }
        public int price { get; set; }

        public string ShopCartId { get; set; }

    }
}
