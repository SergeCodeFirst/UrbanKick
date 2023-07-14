using System;
using System.ComponentModel.DataAnnotations;

namespace UrbanKicks.Models
{
    public class ProductAndOrder
    {
        [Key]
        public int productAndOrderId {get;set;}
        // product id with an instance to get info
        public int productId {get;set;}
        public Product myProduct {get;set;}

        // order id with an instance to get info
        public int orderId {get;set;}
        public Order myOrder {get;set;}
    }
}