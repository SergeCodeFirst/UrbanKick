using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UrbanKicks.Models
{
    public class Order
    {
        [Key]
        public int orderId {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;
        
        // user id
        public int userId {get;set;}
        // user instaces to get info
        public User myUser {get;set;}

        // shipping Address Id 
        public int shippingAddressId {get;set;}
        // shippingAddressId class
        public ShippingAddress myShippingAddress {get;set;}

        // list of products
        List<Product> allProducts {get;set;}

        // product id
        public int productId {get;set;}

        // Product instaces to get info
        public Product myProduct {get;set;}
    }
}