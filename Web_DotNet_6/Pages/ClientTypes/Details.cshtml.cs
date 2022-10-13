using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO_DotNet_6.Context;
using BO_DotNet_6.Models.Entities;

namespace Web_DotNet_6.Pages.ClientTypes
{
    public class DetailsModel : PageModel
    {
        private readonly BO_DotNet_6.Context.TestingContext _context;

        public DetailsModel(BO_DotNet_6.Context.TestingContext context)
        {
            _context = context;
        }

      public ClientType ClientType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClientType == null)
            {
                return NotFound();
            }

            var clienttype = await _context.ClientType.FirstOrDefaultAsync(m => m.Id == id);
            if (clienttype == null)
            {
                return NotFound();
            }
            else 
            {
                ClientType = clienttype;
            }
            return Page();
        }
    }
}
