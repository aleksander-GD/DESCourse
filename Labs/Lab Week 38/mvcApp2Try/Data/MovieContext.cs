using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvcApp2Try.Models     // Enables public DbSet<Movie> Movie
{

    /**
     * The preceding code creates a DbSet<Movie> property for the entity set. 
     * In Entity Framework terminology, an entity set typically corresponds to a database table. 
     * An entity corresponds to a row in the table.
     * 
     * The name of the connection string is passed in to the context by calling a method on a DbContextOptions object. 
     * For local development, the ASP.NET Core configuration system reads the connection string from the appsettings.json file.
     * 
     * The MvcMovieContext object handles the task of connecting to the database and mapping Movie objects to database records. 
     * The database context is registered with the Dependency Injection container in the ConfigureServices method in the Startup.cs file
     */
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<mvcApp2Try.Models.Movie> Movie { get; set; }
    }
}
