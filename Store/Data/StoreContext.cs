using Microsoft.EntityFrameworkCore;

namespace Store.Data {
    public class StoreContext : DbContext {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        public DbSet<Nomenclature> Nomenclature { get; set; }
    }
}
