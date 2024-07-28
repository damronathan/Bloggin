using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SimpleBlogLibrary.Models;

namespace SimpleBlogLibrary.Data;


public class BlogPostContext : DbContext
{
    public BlogPostContext(DbContextOptions<BlogPostContext> options) : base(options) { }

    public DbSet<BlogPost> BlogPost { get; set; }
} 
