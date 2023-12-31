﻿using AspNetCoreIdentity.Mvc.Habilitar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Mvc.Habilitar.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
