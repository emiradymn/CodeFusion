using Microsoft.EntityFrameworkCore;

namespace CodeFusion.Data.Concrete.EfCore
{
    public class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Entity.Tag { Text = "web", Url = "web", Color = Entity.TagColors.warning },
                        new Entity.Tag { Text = "backend", Url = "backend", Color = Entity.TagColors.success },
                        new Entity.Tag { Text = "frontend", Url = "frontend", Color = Entity.TagColors.secondary },
                        new Entity.Tag { Text = "fullstack", Url = "fullstack", Color = Entity.TagColors.warning },
                        new Entity.Tag { Text = "javascript", Url = "javascript", Color = Entity.TagColors.danger }
                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new Entity.User { UserName = "emiradiyaman", Name = "Emir Adiyaman", Image = "frontend1.png,", Email = "info@emiradymn.com", Password = "12345" }

                    );
                    context.SaveChanges();
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Entity.Post
                        {
                            Title = "Asp.net core",
                            Description = "Asp.net core notları",
                            Content = "Asp.net core notları",
                            Url = "aspnet-core",
                            IsActive = true,
                            PublisedOn = DateTime.Now.AddDays(-10), // 10 gün önce eklenmiş olsun
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "frontend1.png",
                            UserId = 1,
                            Comments = new List<Entity.Comment>{
                                new Entity.Comment { Text ="iyi bir framework", PublisedOn = DateTime.Now.AddDays(-5), UserId = 1,},
                                new Entity.Comment { Text ="tavsiye ederim", PublisedOn = DateTime.Now.AddDays(-3), UserId = 2,},}
                        },
                         new Entity.Post
                         {
                             Title = "Node.js",
                             Description = "Node.js  notları",
                             Content = "Node.js  notları",
                             Url = "node-js",
                             IsActive = true,
                             PublisedOn = DateTime.Now.AddDays(-3), // 10 gün önce eklenmiş olsun
                             Tags = context.Tags.Take(2).ToList(),
                             Image = "frontend2.png",
                             UserId = 1
                         },
                         new Entity.Post
                         {
                             Title = "React.js",
                             Description = "React.js notları",
                             Content = "React.js notları",
                             Url = "react-js",
                             IsActive = true,
                             PublisedOn = DateTime.Now.AddDays(-5), // 10 gün önce eklenmiş olsun
                             Tags = context.Tags.Take(4).ToList(),
                             Image = "frontend1.png",
                             UserId = 2
                         }
                    );
                    context.SaveChanges(); //bilgileri db ye ekler

                }
            }

        }
    }
}