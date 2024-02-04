using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace apiTestApp.Models
{
    public class ProductDTO
    {
        [JsonPropertyName("productId")]
         public int ProductId { get; set; }
         [JsonPropertyName("productName")]
        public string ProductName { get; set; } = null!;
        [JsonPropertyName("price")]
        public double Price { get; set; }
    }
}