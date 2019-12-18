using Microsoft.EntityFrameworkCore;
using System.Configuration;

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNo { get; set; }
    public string City { get; set; }
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Gener { get; set; }
}

public class BookingContext : DbContext
{
    public DbSet<Member> Members { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(ConfigurationManager.ConnectionStrings["BookingDatabase"].ConnectionString);
    }
}
