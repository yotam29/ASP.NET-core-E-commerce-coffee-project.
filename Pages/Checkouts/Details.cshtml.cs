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
    public class DetailsModel : PageModel
    {
        private readonly CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context _context;

        public DetailsModel(CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context context)
        {
            _context = context;
        }

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
    }
}
