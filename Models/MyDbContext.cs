﻿using Microsoft.EntityFrameworkCore;

namespace InventoryControl.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
                public DbSet<Users> Users { get; set; }
                public DbSet<Authentication> Authentication { get; set; }
        }

    }
}
