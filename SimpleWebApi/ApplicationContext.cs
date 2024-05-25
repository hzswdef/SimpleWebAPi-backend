using Microsoft.EntityFrameworkCore;
using SimpleWebApi.Models.Form;

namespace SimpleWebApi;

public sealed class ApplicationContext : DbContext
{
    public DbSet<ContactForm> ContactForms { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;user=simplewebapi;password=simplewebapi;database=simplewebapi;", 
            new MySqlServerVersion(new Version(8, 0, 37))
        );
    }
}