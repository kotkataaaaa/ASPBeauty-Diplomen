using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ASPBeauty.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int TypeId { get; set; }
        public ProductType Type { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }  
        public DateTime CreateOn { get; set; } 
        public ICollection<Promotion> Promotions { get; set; }
        public ICollection<Cart> Carts { get; set; }
       



    }
}
