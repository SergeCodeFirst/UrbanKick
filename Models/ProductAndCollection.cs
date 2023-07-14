using System;
using System.ComponentModel.DataAnnotations;

namespace UrbanKicks.Models
{
    public class ProductAndCollection
    {
        [Key]
        public int productAndCollectionId;

         // Collection id with an instance to get info
        public int collectionId {get;set;}
        public Collection myCollection {get;set;}

        // product id with an instance to get info
        public int productId {get;set;}
        public Product myProduct {get;set;}
    }
}