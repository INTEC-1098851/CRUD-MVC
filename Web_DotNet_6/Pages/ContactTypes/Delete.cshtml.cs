using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO_DotNet_6.Context;
using BO_DotNet_6.Models.Entities;

namespace Web_DotNet_6.Pages.ContactTypes
{
    public class DeleteModel : PageModel
    {
        private readonly BO_DotNet_6.Context.TestingContext _context;

        public DeleteModel(BO_DotNet_6.Context.TestingContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ContactType ContactType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ContactType == null)
            {
                return NotFound();
            }

            var contacttype = await _context.ContactType.FirstOrDefaultAsync(m => m.Id == id);

            if (contacttype == null)
            {
                return NotFound();
            }
            else 
            {
                ContactType = contacttype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ContactType == null)
            {
                return NotFound();
            }
            var contacttype = await _context.ContactType.FindAsync(id);

            if (contacttype != null)
            {
                ContactType = contacttype;
                _context.ContactType.Remove(ContactType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
