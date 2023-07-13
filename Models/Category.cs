using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace UrbanKicks.Models
{
    public class Category
    {
        [Key]
        public int categoryId {get;set;}
        public string categoryName {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // all products in a catergory
        List <Product> myProduct {get;set;}
    }
}