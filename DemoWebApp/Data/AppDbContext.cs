using DemoWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DemoWebApp.Data
{
    public class AppDbContext : DbContext
    {
        /*
         * In order to use Entity Framework to query, insert, update, 
         * and delete data using .NET objects, you first need to Create a Model which maps 
         * the entities and relationships that are defined in your model to tables in a 
         * database.

            Once you have a model, the primary class your application interacts with 
            is System.Data.Entity.DbContext (often referred to as the context class). 
            You can use a DbContext associated to a model to:

             - Write and execute queries
             - Materialize query results as entity objects
             - Track changes that are made to those objects
             - Persist object changes back on the database
             - Bind objects in memory to UI controls
         */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
