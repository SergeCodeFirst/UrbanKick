using System;
using System.ComponentModel.DataAnnotations;

namespace UrbanKicks.Models
{
    public class ProductSize
    {
        [Key]
        public int productSizeId {get;set;}
        public string productSize {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;
        
        // product id with instaces to get info
        public int productId {get;set;}
        public Product myProduct {get;set;}
    }
}