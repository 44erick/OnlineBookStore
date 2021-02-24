using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            OnlineBookStoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OnlineBookStoreDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //if there's nothing in the context then go here
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    //making new entries to database
                    new Project
                    {

                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        Isbn = "978-0451419436",
                        Classification = "Fiction",
                        Category = "Classic",
                        Pages = 1488,
                        Price = 9.95

                    },
                    new Project
                    {

                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 944,
                        Price = 14.58
                    },
                    new Project
                    {

                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantman",
                        Isbn = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 832,
                        Price = 21.54
                    },
                    new Project
                    {

                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        Isbn = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 864,
                        Price = 11.61
                    },
                    new Project
                    {

                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        Isbn = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Pages = 528,
                        Price = 13.33
                    },
                    new Project
                    {

                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        Isbn = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Pages = 288,
                        Price = 15.95
                    },
                    new Project
                    {

                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 304,
                        Price = 14.99
                    },
                    new Project
                    {

                        Title = "It's Your Ship",
                        AuthorFirst = "Micahel",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 240,
                        Price = 21.66
                    },
                    new Project
                    {

                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        Isbn = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Pages = 400,
                        Price = 29.46
                    },
                    new Project
                    {

                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        Isbn = "978-0551191613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Pages = 642,
                        Price = 15.03
                    },
                    new Project
                    {
                        Title = "Man's Search for Meaning",
                        AuthorFirst = "Viktor E.",
                        AuthorLast = "Frankl",
                        Publisher = "Beacon Press",
                        Isbn = "978-1433210426",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 188,
                        Price = 9.99
                    },
                    new Project
                    {
                        Title = "The Last Lecture",
                        AuthorFirst = "Randy",
                        AuthorLast = "Pausch",
                        Publisher = "Hyperion",
                        Isbn = "978-1401323257",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 206,
                        Price = 11.34
                    },
                    new Project
                    {
                        Title = "How to win Friends & Influence People",
                        AuthorFirst = "Dale",
                        AuthorLast = "Carnegie",
                        Publisher = "Pocket Books",
                        Isbn = "978-0671027032",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 288,
                        Price = 11.85
                    }
                );
                context.SaveChanges();
            }
        }
    }
}