using Microsoft.AspNetCore.Identity;

namespace ASPBeauty.Data
{
    public class Client:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Cart> Carts { get; set; }

    }
}
