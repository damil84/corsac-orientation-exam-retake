using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using NotebookErrorReporter.Moduls;

namespace NotebookErrorReporter.Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Name> Names { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
