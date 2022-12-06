using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_FINAL_PROJECT_YOTAM.Models;

namespace CIDM_3312_FINAL_PROJECT_YOTAM.B_.Pages.Checkouts
{
    public class DeleteModel : PageModel
    {
        private readonly CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context _context;

        public DeleteModel(CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Checkout Checkout { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Checkouts == null)
            {
                return NotFound();
            }

            var checkout = await _context.Checkouts.FirstOrDefaultAsync(m => m.CheckoutID == id);

            if (checkout == null)
            {
                return NotFound();
            }
            else 
            {
                Checkout = checkout;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Checkouts == null)
            {
                return NotFound();
            }
            var checkout = await _context.Checkouts.FindAsync(id);

            if (checkout != null)
            {
                Checkout = checkout;
                _context.Checkouts.Remove(Checkout);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
