using Microsoft.EntityFrameworkCore;

namespace Banque.Data
{
    public class BanqueContext : DbContext
    {

        public BanqueContext(DbContextOptions<BanqueContext> options) : base(options)
        {
        }

    }
}
