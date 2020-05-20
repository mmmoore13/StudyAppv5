using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace StudyAppV4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TermContext(serviceProvider.GetRequiredService<DbContextOptions<TermContext>>()))
            {
                if (context.Term.Any())
                {
                    return;
                }

                context.Term.AddRange(
                    new Term
                    {
                        Terms = "Force",
                        Subject = "Physics",
                        Definitions = "A Force is any interaction that, when unopposed, will change the motion of an object.",
                        Questions = "What is a Force?",
                        Answers = "A Force is any interaction that, when unopposed, will change the motion of an object."
                    },
                    new Term
                    {
                        Terms = "Differential Equation",
                        Subject = "Math",
                        Definitions = "an equation that relates one or more functions and their derivatives",
                        Questions = "What is a Differential Equation?",
                        Answers = "A differential equation is an equation that relates one or more functions and their derivatives"
                    });
                context.SaveChanges();
            }
        }
    }
}
