using MusicSchool.Models;

namespace Music_Shop.Controllers
{
    public static class Cart
    {
        private static List<CartItem> _cartItems = new List<CartItem>();

        public static void AddToCart(Music song)
        {
            // Implement your logic to add the song to the cart
            // This could involve creating a CartItem class and adding it to the _cartItems list
            _cartItems.Add(new CartItem { SongTitle = song.SongTitle, Perfomer = song.Perfomer });
        }

        public static List<CartItem> GetCartItems()
        {
            // Return the items in the cart
            return _cartItems;
        }
    }

    public class CartItem
    {
        public string SongTitle { get; set; }
        public string Perfomer { get; set; }
    }

}
