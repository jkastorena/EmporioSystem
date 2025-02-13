using Microsoft.EntityFrameworkCore;

namespace EmporioSystem.DATA;

public class EmporioDataContext : DbContext
{
    public EmporioDataContext(DbContextOptions options) : base(options){
        
    }

    public DbSet<Item> Items{ get; set; }
    public DbSet<ItemConfig> ItemConfigs{ get; set; }
    public DbSet<ConfigValue> ConfigValues{ get; set; }
    public DbSet<ServiceMonitor> ServiceMonitors{ get; set; }
}
