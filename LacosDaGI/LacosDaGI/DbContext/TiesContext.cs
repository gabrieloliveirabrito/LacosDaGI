using LacosDaGI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LacosDaGI.DbContext
{
    public class TiesContext : BaseDbContext<TiesContext>
    {
        public DbSet<Tie> Ties { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
    }
}
