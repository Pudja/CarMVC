using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pudja.VeichleDB.Models
{
    public class VDbContext : DbContext
    {
        public VDbContext(DbContextOptions<VDbContext> options) : base(options)
        {

        }

        public DbSet<VMake> Makes { get; set; }

        public DbSet<VModel> Models { get; set; }
    }
}
