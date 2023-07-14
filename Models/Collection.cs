using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UrbanKicks.Models
{
    public class Collection
    {
        [Key]
        public int collectionId {get;set;}
        public string collectionName {get;set;}
        public DateTime createdAt {get;set;} = DateTime.Now;
        public DateTime updatedAt {get;set;} = DateTime.Now;

        // list of all products part of a collection
        List <Product> allProducts {get;set;}

    }
}