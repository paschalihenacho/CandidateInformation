using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateInformation.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CandidateInformationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CandidateInformationContext>>()))
            {
                // Look for any candidate.
                if (context.Candidate.Any())
                {
                    return;   // DB has been seeded
                }

                context.Candidate.AddRange(
                    new Candidate
                    {
                        firstName = "Paschal",
                        lastName = "Ihenacho",
                        email = "ihenachopaschal@yahoo.com",
                        phoneNumber = "(832) 641-2011",
                        zipCode = "77042",
                        qualificationType = "College Degree",
                        qualificationName = "University of Houston Downtown",
                        startDate = DateTime.Parse("2012-2-12"),
                        endDate = DateTime.Parse("2016-8-12")
                    },

                     new Candidate
                     {
                        firstName = "Paschal",
                        lastName = "Ihenacho",
                        email = "ihenachopaschal@yahoo.com",
                        phoneNumber = "(832) 641-2011",
                        zipCode = "77042",
                        qualificationType = "Job Experience",
                        qualificationName = "Joe's Crab Shack",
                        startDate = DateTime.Parse("2012-2-12"),
                        endDate = DateTime.Parse("2016-8-12")
                     },

                     new Candidate
                     {
                         firstName = "James",
                         lastName = "Matthews",
                         email = "James.Matthews@yahoo.com",
                         phoneNumber = "(281) 641-2011",
                         zipCode = "77043",
                         qualificationType = "Junior College Degree",
                         qualificationName = "Houston Community College",
                         startDate = DateTime.Parse("2012-2-12"),
                         endDate = DateTime.Parse("2014-8-12")
                     },

                     new Candidate
                     {
                         firstName = "John",
                         lastName = "Doe",
                         email = "John.Doe@yahoo.com",
                         phoneNumber = "(713) 641-2011",
                         zipCode = "77023",
                         qualificationType = "Junior College Degree",
                         qualificationName = "Houston Community College",
                         startDate = DateTime.Parse("2012-2-12"),
                         endDate = DateTime.Parse("2014-8-12")
                     },

                    new Candidate
                    {
                        firstName = "Tony",
                        lastName = "Bret",
                        email = "Tony.Bret@yahoo.com",
                        phoneNumber = "(713) 641-2011",
                        zipCode = "77023",
                        qualificationType = "Work Experience",
                        qualificationName = "Electrical Technician",
                        startDate = DateTime.Parse("2012-2-12"),
                        endDate = DateTime.Parse("2016-8-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}