namespace MoneyApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoneyApp.Models.MoneyAppModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MoneyApp.Models.MoneyAppModel context)
        {
            context.User.AddOrUpdate(
                    x => x.username,
                    new User { username = "hyg1997", password = "123456", name = "Hugo Andrés", lastname = "Yupanqui Gómez" },
                    new User { username = "saintplay", password = "123456", name = "Diego Alfredo", lastname = "Jara Palomino" }
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
