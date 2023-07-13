using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace UrbanKicks.Models
{
    public class Brand
    {
        [Key]
        public int brandId {get;set;}
        public string brandName {get;set;}
        public string brandEmail {get;set;}
        public string brandPhoneNo {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // all Product from our brand
        List <Product> allProducts {get;set;}
    }
}