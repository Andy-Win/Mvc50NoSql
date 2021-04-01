using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc50NoSql.Models;

namespace Mvc50NoSql.Data
{
    public class Mvc50NoSqlContext : DbContext
    {
        public Mvc50NoSqlContext (DbContextOptions<Mvc50NoSqlContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc50NoSql.Models.Movie> Movie { get; set; }
    }
}
