using AutoTransportationServer.Configuration;
using AutoTransportationServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTransportationServer.Data;

public class TransportationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Fuel> Fuel { get; set; }
    public DbSet<Auto> Autos { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Transportation> Transportations { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Person> Persons { get; set; }


    //настройка строки подключения
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
        var connectionString = "server=localhost;port=3306;database=AutoTransportation;user id=root;password=BuildSQLData;";

        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InitDBPerson());
        modelBuilder.ApplyConfiguration(new InitDBAdmin());

        base.OnModelCreating(modelBuilder);
    }
}
