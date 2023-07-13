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

        // order id with an instance to get info
        public int orderId {get;set;}
        public Order myOrder {get;set;}

        // list of all orders our product is part of
        List <Order> allOrders {get;set;}

        // list of product size our product has
        List <ProductSize> myProductSize {get;set;}

        // category id with an instance to get info
        public int categoryId {get;set;}
        public Category myCategory {get;set;}

        // brant id with an instance to get info
        public int brandId {get;set;}
        public Brand myBrand {get;set;}

        // Collection id with an instance to get info
        public int collectionId {get;set;}
        public Collection myCollection {get;set;}

        // list of all Collection our product is part of
        List <Collection> allCollections {get;set;}
    }
}