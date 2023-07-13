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
        
        // user id with an instance to get info
        public int userId {get;set;}
        public User myUser {get;set;}

        // shipping Address id with an instance to get info
        public int shippingAddressId {get;set;}
        public ShippingAddress myShippingAddress {get;set;}

        // list of products in our Order
        List<Product> allProducts {get;set;}

        // product id with an instance to get info
        public int productId {get;set;}
        public Product myProduct {get;set;}
    }
}