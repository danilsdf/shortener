﻿using Microsoft.EntityFrameworkCore;
using ShortenerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerApi.EntityFramework
{
    public class ShortenerContext : DbContext
    {

        public ShortenerContext(DbContextOptions<ShortenerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Url> Urls { get; set; }
    }
}
