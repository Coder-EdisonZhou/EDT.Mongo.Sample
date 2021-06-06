﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EDT.BookStore.API.Models
{
    public class Book : MongoDocBase
    {
        [BsonElement("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
