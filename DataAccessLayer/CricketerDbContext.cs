using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public  class CricketerDbContext:DbContext
    {
        public CricketerDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<CricketerDetails> CricketerDetail { get; set; }
    }
}
