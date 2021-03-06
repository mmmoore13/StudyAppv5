using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;

    public class TermContext : DbContext
    {
        public TermContext (DbContextOptions<TermContext> options)
            : base(options)
        {
        }

        public DbSet<StudyApp.Models.Term> Term { get; set; }
    }
