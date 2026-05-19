using System.Reflection.Metadata;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ASPBeauty.Data
{
    public class Cart
    {
        public int Id { get; set; } 
        public string ClientId { get; set; } 
        public Client Client { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; } = 1;

    }
}
