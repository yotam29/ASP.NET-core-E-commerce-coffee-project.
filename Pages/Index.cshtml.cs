using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_FINAL_PROJECT_YOTAM.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_FINAL_PROJECT_YOTAM.B_.Pages;

public class IndexModel : PageModel
{
    private readonly Context _context;
    private readonly ILogger<IndexModel> _logger;
    
    
    public IndexModel(Context context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }
    public List <item> items {get;set;}= default!;
    [BindProperty(SupportsGet = true)]
    public string CurrentSort {get;set;}
    [BindProperty (SupportsGet = true)]
    public int PageNum {get;set;} =1;
    public int PageSize {get;set;}=10;

    // Search bar
    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    // pass a list to the checkout

    [BindProperty]
    public cart cart {get;set;} = default!;
    
    public SelectList CartDropDown {get;set;}= default!;
    // public void OnGet()
    // {
    //     CartDropDown= new SelectList(_context.items.ToList(),"itemID","item_name");
        
    // }
    public IActionResult OnPost()
    {
        if(!ModelState.IsValid)
        {
            return Page();
        }
        // Course =_context.Professors.Include(m => m.Courses).First(m => m.Id == Id)
        _context.carts.Add(cart);
        _context.SaveChanges();
        return RedirectToPage("./Checkouts/Index");
    }

    public async void OnGetAsync()
    {
        //test
        CartDropDown= new SelectList(_context.items.ToList(),"itemID","item_name");


        var query =_context.items.Select(i =>i);
        switch(CurrentSort)
        {
            case "first_asc":
                query=query.OrderBy(i=>i.item_name);
                break;
            case "first_desc":
                query=query.OrderByDescending(i=>i.item_name);
                break;


        }

        items = _context.items.ToList();
        items =await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

        // using System.Linq (Search bar)
            var item = from i in _context.items
                            select i;
            if (!string.IsNullOrEmpty(SearchString))
                {
                    item = item.Where(i => i.item_name.Contains(SearchString));
                }
            
    }
}
