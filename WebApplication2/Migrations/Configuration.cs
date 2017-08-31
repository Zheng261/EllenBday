namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using WebApplication2.Models.Entities;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.DataContext context)
        {
            context.TimeEntries.AddOrUpdate(
                p => p.Id,
                    new Models.Entities.TimeEntry { Id = 1, Day = 1, Slot = 1, Time= "like maybe 3", Information ="hello"},
                    new Models.Entities.TimeEntry { Id = 2, Day = 1, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 3, Day = 1, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 4, Day = 1, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 5, Day = 1, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 6, Day = 1, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 7, Day = 1, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 8, Day = 2, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 9, Day = 2, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 10, Day = 2, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 11, Day = 2, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 12, Day = 2, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 13, Day = 2, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 14, Day = 2, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 15, Day = 3, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 16, Day = 3, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 17, Day = 3, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 18, Day = 3, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 19, Day = 3, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 20, Day = 3, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 21, Day = 3, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 22, Day = 4, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 23, Day = 4, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 24, Day = 4, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 25, Day = 4, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 26, Day = 4, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 27, Day = 4, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 28, Day = 4, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 29, Day = 5, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 30, Day = 5, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 31, Day = 5, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 32, Day = 5, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 33, Day = 5, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 34, Day = 5, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 35, Day = 5, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 36, Day = 6, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 37, Day = 6, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 38, Day = 6, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 39, Day = 6, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 40, Day = 6, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 41, Day = 6, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 42, Day = 6, Slot = 7 },
                    new Models.Entities.TimeEntry { Id = 43, Day = 7, Slot = 1 },
                    new Models.Entities.TimeEntry { Id = 44, Day = 7, Slot = 2 },
                    new Models.Entities.TimeEntry { Id = 45, Day = 7, Slot = 3 },
                    new Models.Entities.TimeEntry { Id = 46, Day = 7, Slot = 4 },
                    new Models.Entities.TimeEntry { Id = 47, Day = 7, Slot = 5 },
                    new Models.Entities.TimeEntry { Id = 48, Day = 7, Slot = 6 },
                    new Models.Entities.TimeEntry { Id = 49, Day = 7, Slot = 7 }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
