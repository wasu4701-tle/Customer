using System;
using Microsoft.EntityFrameworkCore;
using Projecttitle.Models;

namespace Projecttitle.Data;

public class MyApplicationDbContext : DbContext
{
    public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    
    }



