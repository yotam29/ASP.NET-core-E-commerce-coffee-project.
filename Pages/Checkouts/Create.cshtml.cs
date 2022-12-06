using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIDM_3312_FINAL_PROJECT_YOTAM.Models;

namespace CIDM_3312_FINAL_PROJECT_YOTAM.B_.Pages.Checkouts
{
    public class CreateModel : PageModel
    {
        private readonly CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context _context;

        public CreateModel(CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Checkout Checkout { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Checkouts == null || Checkout == null)
            {
                return Page();
            }

            _context.Checkouts.Add(Checkout);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
