using Microsoft.EntityFrameworkCore;
using YandexMarketParser.Models;

namespace YandexMarketParser.Data {
    public class ApplicationDbContext: DbContext {
        public DbSet<Offer> Offers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
    }
}
