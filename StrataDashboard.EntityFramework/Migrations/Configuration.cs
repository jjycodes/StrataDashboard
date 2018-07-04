using System.Data.Entity.Migrations;

namespace StrataDashboard.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StrataDashboard.EntityFramework.StrataDashboardDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StrataDashboard";
        }

        protected override void Seed(StrataDashboard.EntityFramework.StrataDashboardDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
