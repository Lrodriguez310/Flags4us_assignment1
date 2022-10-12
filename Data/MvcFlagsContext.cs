using System;
using Microsoft.EntityFrameworkCore;
using Flags4us_assignment1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flags4us_assignment1.Data
{
    public class MvcFlagsContext : DbContext
    {

        public MvcFlagsContext(DbContextOptions<MvcFlagsContext> options)
                   : base(options)
        {
        }

        public DbSet<Flags> Flags { get; set; }
    }
}
