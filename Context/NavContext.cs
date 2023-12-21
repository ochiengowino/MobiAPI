﻿using Microsoft.EntityFrameworkCore;
using MobiAPI.Models;


namespace MobiAPI.Context
{
    public class NavContext: DbContext
    {
      
        public NavContext(DbContextOptions<NavContext> options) : base(options) { }
        public DbSet<NavTransactions> NavTransactions { get; set; }
    }
}
