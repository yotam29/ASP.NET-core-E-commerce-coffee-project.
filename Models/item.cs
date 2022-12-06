using System.ComponentModel.DataAnnotations;
namespace CIDM_3312_FINAL_PROJECT_YOTAM.Models
{
    public class item
    {
        public int itemID {get;set;} //pk
        [Required]
        public string? item_name {get;set;}
        [Required]
        public int item_price {get;set;}
        [Required]
        public string? item_description {get;set;} 
        public List<cart> carts{get;set;} =default!; // nav proprty to have many items in cart 
    }
    public class cart
    {
        public int itemID {get;set;}// composite pk 
        public int CheckoutID {get;set;}// composite pk
        public item item {get;set;} = default!;
        public Checkout checkout {get;set;} = default!;
        [Required]
        public string? quantity {get;set;}
        
    }
}