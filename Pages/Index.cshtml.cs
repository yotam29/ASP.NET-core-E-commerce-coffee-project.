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
    [BindProperty]
    public int selectedItemId {get; set;}
    
    public SelectList CartDropDown {get;set;}= default!; // might be deletaed 

    public IActionResult OnPost()
    {
        _logger.LogWarning($"Item ID Selected: {selectedItemId}");
        cart.itemID = selectedItemId;
        cart.item = _context.items.Find(selectedItemId)!;
        cart.quantity = "1"; // unsure
        cart.CheckoutID = 1; // You need to figure out how to populate the "Checkout" entity class. 
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

        // using System.Linq (Search bar)
        // Do the search query first and use the same LINQ variable throughout this method
        if (!string.IsNullOrEmpty(SearchString))
        {
            query = query.Where(i => i.item_name.Contains(SearchString));
        }
        
        switch(CurrentSort)
        {
            case "first_asc":
                query=query.OrderBy(i=>i.item_name);
                break;
            case "first_desc":
                query=query.OrderByDescending(i=>i.item_name);
                break;



        }
        
        items =await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
    }
}
