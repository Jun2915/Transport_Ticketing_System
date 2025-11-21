using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 

namespace ASS_WMS.Models;

#nullable disable warnings

public class DB(DbContextOptions options) : DbContext(options)
{
    //DB Sets
    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Customer> Customers { get; set; }
}

//===========================================================
//Entity Classes
//===========================================================

public class User
{
    [Key,MaxLength(5)]
    public  string Id { get; set; }
    [MaxLength(20)]
    public string Name { get; set; }
    [MaxLength(30)]
    public string Email { get; set; }
    [MaxLength(50)]
    public string Password { get; set; }
    [MaxLength(11)]
    public string PhoneNumber { get; set; }

}

public class Admin : User
{
    [MaxLength(100)]
    public string PhotoURL { get; set; }
}

public class Customer : User
{
    [MaxLength(100)]
    public string PhotoURL { get; set; }
}