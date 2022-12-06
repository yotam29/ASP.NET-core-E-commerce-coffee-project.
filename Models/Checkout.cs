using System.ComponentModel.DataAnnotations;
namespace CIDM_3312_FINAL_PROJECT_YOTAM.Models
{
    public class Checkout
    {
        public int CheckoutID {get;set;}
        public int itemID {get;set;}
        [Required]
        public string? UserName {get;set;}
        [Required]
        public int totoal_price {get;set;}
         public List<cart> carts{get;set;} =default!; // nav proprty to have many checkouts in carts

    }
}