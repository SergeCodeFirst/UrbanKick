using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UrbanKicks.Models
{
    public class User
    {
        [Key]
        public int userId {get;set;}
        public string first_name {get;set;}
        public string last_name {get;set;}
        public string email {get;set;}
        public string street_address {get;set;}
        public string city {get;set;}
        public string state {get;set;}
        public int zipcode {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now; 
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // list of all ShippingAddress our user has
        public List<ShippingAddress> userShippingAddresses {get;set;}

        // list of Order
        public List<Order> userOders {get;set;}
    }
}