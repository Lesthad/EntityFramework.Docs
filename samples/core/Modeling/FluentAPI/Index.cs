﻿using Microsoft.EntityFrameworkCore;

namespace EFModeling.FluentAPI.Index
{
    #region Index
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasIndex(b => b.Url);
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
    #endregion
}
