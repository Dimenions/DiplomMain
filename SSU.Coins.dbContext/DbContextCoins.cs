using Microsoft.EntityFrameworkCore;
using SSU.Coins.dbContext;

public class CoinsContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RoleWebSite> RoleWebSites { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Coin> Coins { get; set; }
    //public DbSet<UserCoin> UserCoins { get; set; }
    //public DbSet<SaleCoins> SaleCoins { get; set; }

    //Add-Migration Initial
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //optionsBuilder.UseSqlServer(Configuration[]"ConnectionString");
            optionsBuilder.UseSqlServer(@"Server = (LocalDb)\MSSQLLocalDB; initial catalog = SSU.Coins.dbContext.SSU.Coin; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
        }
        //.\SQLEXPRESS01
        //Add-Migration InitialCreate
        //add-migration Reset
        //Update-Database
    }

    public CoinsContext(DbContextOptions<CoinsContext> options)
            : base(options)
    { }
}
