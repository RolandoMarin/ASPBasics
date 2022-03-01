#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPBasics.Models;

namespace ASPBasics.Data
{
    public class ASPBasicsContext : DbContext
    {
        public ASPBasicsContext (DbContextOptions<ASPBasicsContext> options)
            : base(options)
        {
        }

        public DbSet<ASPBasics.Models.Course> Course { get; set; }
    }
}
