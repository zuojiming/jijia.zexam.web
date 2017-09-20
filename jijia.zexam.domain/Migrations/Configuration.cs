namespace jijia.zexam.domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<jijia.zexam.domain.models.ZExamEntiteis>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "jijia.zexam.domain.models.ZExamEntiteis";
        }

        protected override void Seed(jijia.zexam.domain.models.ZExamEntiteis context)
        {
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
