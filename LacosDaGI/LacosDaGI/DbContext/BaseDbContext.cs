using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LacosDaGI.DbContext
{
    using Dependencies;

    public abstract class BaseDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        /*private static TContext instance;
        public static TContext Instance
        {
            get => instance ?? (instance = Activator.CreateInstance<TContext>());
        }*/

        public async Task Initialize()
        {
            await Database.EnsureCreatedAsync();
            await SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Paths.DbPath}");
        }
    }
}
