﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarginalCakes.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories{ get; set; }

    }
}
