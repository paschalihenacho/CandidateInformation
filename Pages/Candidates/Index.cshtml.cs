using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateInformation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MediaBrowser.Controller.Entities.Movies;

namespace CandidateInformation.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly CandidateInformation.Models.CandidateInformationContext _context;

        public IndexModel(CandidateInformation.Models.CandidateInformationContext context)
        {
            _context = context;
        }

        public string LNameSort { get; set; }
        public string SDateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Candidate> Candidate { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList lastName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CandidateLastName { get; set; }

        public async Task OnGetAsync(string sortOrder,string searchString)
        // Use LINQ to get list of genres.
        {
            // this code sorts 
            LNameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            SDateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentFilter = searchString;

            IQueryable<Candidate> candidates = from s in _context.Candidate
                                               select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                candidates = candidates.Where(s => s.firstName.Contains(searchString)
                                        || s.lastName.Contains(searchString)
                                        || s.qualificationName.Contains(searchString)
                                        || s.qualificationType.Contains(searchString)
                                        || s.zipCode.Contains(searchString)
                                        || s.phoneNumber.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    candidates = candidates.OrderByDescending(s => s.lastName);
                    break;
                case "Date":
                    candidates = candidates.OrderBy(s => s.startDate);
                    break;
                case "date_desc":
                    candidates = candidates.OrderByDescending(s => s.startDate);
                    break;
                default:
                    candidates = candidates.OrderBy(s => s.lastName);
                    break;
            }
            Candidate = await candidates.AsNoTracking().ToListAsync();
        }

            //var candidates = from m in _context.Candidate
            //                 //where m.firstName.Contains(SearchString)
            //                // where m.lastName.Contains(SearchString)
            //             select m;
            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    candidates = candidates.Where(s => s.lastName.Contains(SearchString));
            //}

            //Candidate = await candidates.ToListAsync();
        
    }
}
