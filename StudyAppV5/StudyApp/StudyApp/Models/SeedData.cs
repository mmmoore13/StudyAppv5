using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace StudyApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TermContext(serviceProvider.GetRequiredService<DbContextOptions<TermContext>>()))
            {
                // Look for any movies.
                if (context.Term.Any())
                {
                    return;   // DB has been seeded
                }
                context.Term.AddRange(
                    new Term
                    {
                        TermID = 1,
                        Terms = "Physics",
                        Subject = "General Information",
                        Definitions = "Physics is the branch of science concerned with the nature and properties of matter and energy",
                        Questions = "What is Physics?",
                        Answers = "Physics is the branch of science concerned with the nature and properties of matter and energy"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
