namespace SchoolProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using SchoolProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolProject.Models.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolProject.Models.MyDatabase context)
        {
            Student s1 = new Student()
            {
                FirstName = "Stathis",
                LastName = "Kanellis",
                Birth = new DateTime(1981, 04, 12),
                Fees = 2250D
            };

            context.Students.Add(s1);
            context.SaveChanges();
        }
    }
}
