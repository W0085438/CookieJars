using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookieJars.Models;

namespace CookieJars.Data
{
    public class CookieJarsContext : DbContext
    {
        public CookieJarsContext (DbContextOptions<CookieJarsContext> options)
            : base(options)
        {
        }

        public DbSet<CookieJars.Models.Jars> Jars { get; set; }
    }
}
