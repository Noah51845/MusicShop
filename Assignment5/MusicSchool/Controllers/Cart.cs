﻿using MusicSchool.Models;

namespace Music_Shop.Controllers
{
    public static class Cart
    {
        private static List<CartItem> _cartItems = new List<CartItem>();

        public static void AddToCart(Music song)
        {
           //add price movement here to move from the two pages
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