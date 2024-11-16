using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoggingDemo.Models;

namespace LoggingDemo.Data
{
    public class LoggingDemoContext : DbContext
    {
        public LoggingDemoContext (DbContextOptions<LoggingDemoContext> options)
            : base(options)
        {
        }

        public DbSet<LoggingDemo.Models.Employee> Employee { get; set; } = default!;
    }
}
