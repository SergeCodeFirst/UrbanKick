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

        // user id 
        public int userId {get;set;}
        // A user class
        public User myUser {get;set;}

        // list of Order 
        public List<Order> myOrders {get;set;}

    }
}