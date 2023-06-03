using System;
using System.Text.Json.Serialization;

namespace comanda_backend.Domain.Models.Products
{
	public class ProductsModel  
	{
		[JsonPropertyName("id")]
		public Guid Id { get; set; }

		[JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("quantity")]
        public short Quantity { get; set; }
    }
}

