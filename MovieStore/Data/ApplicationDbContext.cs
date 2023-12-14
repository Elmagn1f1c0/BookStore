﻿using Microsoft.EntityFrameworkCore;
using MovieStore.Models;

namespace MovieStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Category> categories { get; set; }
    }
}
