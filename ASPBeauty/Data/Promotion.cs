using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ASPBeauty.Data
{
    public class Promotion
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }   
    }
}
