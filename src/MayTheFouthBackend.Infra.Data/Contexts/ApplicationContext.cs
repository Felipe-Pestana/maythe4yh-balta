﻿using MayTheFouthBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MayTheFouthBackend.Infra.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; }
    }
}
