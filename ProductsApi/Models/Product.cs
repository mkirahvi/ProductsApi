﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductsApi.Models
{
    public class Product : Item
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

        [BsonElement("link")]
        public string Link { get; set; }

        [BsonElement("available")]
        public bool Available { get; set; }

        [BsonElement("history")]
        public IEnumerable<ProductHistory> History { get; set; }

        [BsonElement("subscribers")]
        public IEnumerable<Object> Subscribers { get; set; }
    }
}
