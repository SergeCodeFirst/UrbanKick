using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UrbanKicks.Models
{
    public class Product
    {
        [Key]
        public int productId {get;set;}
        public string productName {get;set;}
        public string productDescription {get;set;}
        public int productPrice {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // order Id
        public int orderId {get;set;}
        // order instaces to get info
        public Order myOrder {get;set;}

        // list of orders
        List <Order> allOrders {get;set;}
    }
}