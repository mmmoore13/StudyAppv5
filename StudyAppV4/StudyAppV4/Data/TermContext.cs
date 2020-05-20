using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyAppV4.Models;

    public class TermContext : DbContext
    {
        public TermContext (DbContextOptions<TermContext> options)
            : base(options)
        {
        }

        public DbSet<StudyAppV4.Models.Term> Term { get; set; }
    }
