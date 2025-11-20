using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASS_WMS.Models
{
    public class DB(DbContextOptions options) : DbContext(options)
    {
        //Database Sets
        public DbSet<User> Users {  get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Member> Members { get; set; }
    }

    //============================================================
    // Entity Classes
    //============================================================

    public class User
    {
        [Key, MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public string Role => GetType().Name;
    }

    public class Admin : User
    {
        [MaxLength(100)]
        public string PhotoURL { get; set; }
    }

    public class Member : User
    {
        [MaxLength(100)]
        public string PhotoURL { get; set; }
    }
}
