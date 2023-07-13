using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UrbanKicks.Models
{
    public class ShippingAddress
    {
        [Key]
        public int shippingAddressId {get;set;}
        public string streetAddress {get;set;}
        public string city {get;set;}
        public string state {get;set;}
        public int zipcode {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // User id with an instance to get info
        public int userId {get;set;}
        public User myUser {get;set;}

        // list of all Orders to or shipping address
        public List<Order> myOrders {get;set;}

    }
}