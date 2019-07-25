using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seeker.Data.Models;

namespace Seeker.Data
{

    public class SeekerContext : 
        IdentityDbContext<SeekerUser>
    {
        public SeekerContext(DbContextOptions<SeekerContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);// customize the asp.net identity model and override the defaults if needed.// for example, you can rename the asp.net identity table names and more.// add your customizations after calling base.onmodelcreating(builder);
        }
    }
}
