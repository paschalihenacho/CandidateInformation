using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateInformation.Models;

namespace CandidateInformation.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly CandidateInformation.Models.CandidateInformationContext _context;

        public DetailsModel(CandidateInformation.Models.CandidateInformationContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.ID == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
