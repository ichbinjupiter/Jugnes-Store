namespace JugnesStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JugnesStore.Models.JugnesModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(JugnesStore.Models.JugnesModel context)
        {
            context.ManagerTypes.AddOrUpdate(s => s.ID, new Models.ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(s => s.ID, new Models.ManagerType() { ID = 2, Name = "Moderatör" });

            context.Managers.AddOrUpdate(s => s.ID, new Models.Manager() { ID = 1, ManagerType_ID = 1, Name = "Enes", Surname = "Şengül", Email = "eness_26@hotmail.com", Password = "123456789", Status = true });
        }
    }
}
