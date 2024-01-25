using ComicWebApplication.Models;
using Microsoft.AspNetCore.Identity;

namespace ComicWebApplication.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Characters.Any())
                {
                    context.Characters.AddRange(new List<Character>()
                    {
                        new Character()
                        {
                            Name = "Havok",
                            Superpower = "Cosmic energy",
                            Description = "Havok potrafi absorbować kosmiczną energię z otaczającego go środowiska i przechowywać je w komórkach swojego ciała. Jego metabolizm przetwarza tą energię, umożliwiając mu emitowanie potężnych fal plazmowych.",
                            ImageURL = "https://www.writeups.org/wp-content/uploads/Havok-Marvel-Comics-X-Men-Alex-Summers.jpg"
                         },
                        new Character()
                        {
                            Name = "Superman",
                            Superpower = "Everything",
                            Description = "No kozak.",
                            ImageURL = "https://www.sideshow.com/cdn-cgi/image/quality=90,f=auto/https://www.sideshow.com/storage/product-images/907776/superman_dc-comics_gallery_63d968c63ed55.jpg"
                         }
                    });
                    context.SaveChanges();
                }

                if (!context.Comics.Any())
                {
                    context.Comics.AddRange(new List<Comic>()
                    {
                        new Comic()
                        {
                            Title = "Uncanny X-Men",
                            Number = 54,
                            Description = "Seria Uncanny Avengers (Marvel Now)",
                            ReleaseYear = 2018,
                            ImageURL = "https://cf-tk.statiki.pl/images/large/208/9788328126589.jpg"
                         }
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "X-Men: First Class",
                            Director = "Matthew Vaughn",
                            Description = "Sebastian Shaw i jego sojusznicy chcą wywołać konflikt, który może zagrozić całemu światu. Jedyną nadzieją dla ludzkości są X-meni.",
                            ReleaseYear = 2011,
                            ImageURL = "https://m.media-amazon.com/images/I/91XViseGbrL._AC_UF1000,1000_QL80_.jpg"
                         }
                    });
                    context.SaveChanges();
                }

                if (!context.Worlds.Any())
                {
                    context.Worlds.AddRange(new List<World>()
                    {
                        new World()
                        {
                            Name = "Marvel",
                            Description = "Najstarszy oraz najbardziej spopularyzowany amerykański producent i wydawca komiksów na świecie założony w 1933 roku na terenie USA w Nowym Jorku. Właścicielem firmy jest The Walt Disney Company",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Marvel_Logo.svg/1920px-Marvel_Logo.svg.png"
                         }
                    });
                    context.SaveChanges();
                }

                
            }
        }
        /*public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "testAdmin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        UserName = "testAdmin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "zaq1@WSX");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "testUser@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        UserName = "testUser",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "zaq1@WSX");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }*
        }*/
    }
}
