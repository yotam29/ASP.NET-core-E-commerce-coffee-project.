using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_FINAL_PROJECT_YOTAM.Models;

namespace CIDM_3312_FINAL_PROJECT_YOTAM.B_.Pages.Checkouts
{
    public class EditModel : PageModel
    {
        private readonly CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context _context;

        public EditModel(CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context context)
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

            var checkout =  await _context.Checkouts.FirstOrDefaultAsync(m => m.CheckoutID == id);
            if (checkout == null)
            {
                return NotFound();
            }
            Checkout = checkout;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Checkout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckoutExists(Checkout.CheckoutID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CheckoutExists(int id)
        {
          return (_context.Checkouts?.Any(e => e.CheckoutID == id)).GetValueOrDefault();
        }
    }
}
