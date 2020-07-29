using Lab23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieListContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie() { Title = "Moon", Genre = "Scifi", Runtime = 97 });
                context.Movies.Add(new Movie() { Title = "Star Trek II : The Wrath of Khan", Genre = "Scifi", Runtime = 113 });
                context.Movies.Add(new Movie { Title = "The Matrix", Genre = "Scifi", Runtime = 150 });
                context.Movies.Add(new Movie { Title = "Ad Astra", Genre = "Scifi", Runtime = 124 });
                context.Movies.Add(new Movie { Title = "Shrek", Genre = "Animated", Runtime = 95 });
                context.Movies.Add(new Movie { Title = "Frozen", Genre = "Animated", Runtime = 109 });
                context.Movies.Add(new Movie { Title = "Finding Nemo", Genre = "Animated", Runtime = 100 });
                context.Movies.Add(new Movie { Title = "My Neighbor Totoro", Genre = "Animated", Runtime = 88 });
                context.Movies.Add(new Movie { Title = "Moonlight", Genre = "Drama", Runtime = 111 });
                context.Movies.Add(new Movie { Title = "A Beautiful Day in the Neighborhood", Genre = "Drama", Runtime = 109 });
                context.Movies.Add(new Movie { Title = "A Star is Born (2018)", Genre = "Drama", Runtime = 134 });
                context.Movies.Add(new Movie { Title = "Selma", Genre = "Drama", Runtime = 128 });
                context.Movies.Add(new Movie { Title = "The Omen (1976)", Genre = "Horror", Runtime = 111 });
                context.Movies.Add(new Movie { Title = "Holloween (1978)", Genre = "Horror", Runtime = 91 });
                context.Movies.Add(new Movie { Title = "The Exorcist", Genre = "Horror", Runtime = 132 });
                context.Movies.Add(new Movie { Title = "Scream", Genre = "Horror", Runtime = 111 });

                context.SaveChanges();
            }
        }
    }
}
