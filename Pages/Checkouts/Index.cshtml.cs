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
    public class IndexModel : PageModel
    {
        private readonly CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context _context;

        public IndexModel(CIDM_3312_FINAL_PROJECT_YOTAM.Models.Context context)
        {
            _context = context;
        }

        public IList<Checkout> Checkout { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Checkouts != null)
            {
                Checkout = await _context.Checkouts.ToListAsync();
            }
        }
    }
}
