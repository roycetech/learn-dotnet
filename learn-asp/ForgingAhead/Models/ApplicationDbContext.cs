// using System;
using Microsoft.EntityFrameworkCore;


namespace ForgingAhead {
    public class ApplicationDbContext : DbContext {
        public DbSet<Character> Characters { get; set; }
    }
}