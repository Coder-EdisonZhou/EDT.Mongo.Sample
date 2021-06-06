using System;
using System.Text.Json.Serialization;

namespace EDT.BookStore.API.Models
{
    public class CreateBookDto
    {
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
