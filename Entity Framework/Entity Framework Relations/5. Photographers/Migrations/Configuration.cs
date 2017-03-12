namespace _5.Photographers.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_5.Photographers.Data.PhotographerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_5.Photographers.Data.PhotographerContext context)
        {
            Photographer teo = new Photographer
            {
                Username = "teo",
                Password = "asdfadfadf",
                Email = "teo@softuni.bg",
                BirthDate = DateTime.Now,
                RegistereDate = DateTime.Now.AddDays(-20)
            };

            context.Photographers.AddOrUpdate(p=>p.Username,teo);

            context.SaveChanges();

            var demoPicture = new Picture()
            {
                Title = "Demo",
                Caption = "Demo",
                FileSystemPath = "../images/demo.png"
            };

            context.Pictures.AddOrUpdate(p=>p.Title, demoPicture);

            var vitosha = new Album()
            {
                Name = "Vitosha",
                BackgroundColor = "Black",
                IsPublic = true,
                OwnerId = teo.Id
            };

            context.Albums.AddOrUpdate(a => a.Name, vitosha);

            vitosha.Pictures.Add(demoPicture);
            context.SaveChanges();
        }
    }
}
