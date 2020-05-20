using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyAppV2.Models;

    public class TermContext : DbContext
    {
        public TermContext (DbContextOptions<TermContext> options)
            : base(options)
        {
        }

        public DbSet<StudyAppV2.Models.Study> Study { get; set; }

        public DbSet<StudyAppV2.Models.Term> Term { get; set; }
    }
