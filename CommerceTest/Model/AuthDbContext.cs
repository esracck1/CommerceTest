using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommerceTest.Model
{
    public class AuthDbContext:IdentityDbContext
    {
        

        public AuthDbContext()
        {

        }

        public AuthDbContext(DbContextOptions<AuthDbContext> options):base(options)
        {

        }
        
    }
}
