using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Controllers;
using MusicSchool.Data;
using MusicSchool.Models;

namespace MusicSchool.Controllers // dont worry bout why this is music school 
{
    public class CartController : Controller
    {
        private readonly MusicShopContext _context;

        public CartController(MusicShopContext context)
        {
            _context = context;
        }

        // GET: Cart/Index
        public IActionResult Index()
        {
            // Get the items in the shopping cart using the Cart class
            var cartItems = Cart.GetCartItems();

            // Pass the cart items to the Cart/Index view
            return View(cartItems);
        }

        // GET: Cart/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Music == null)
            {
                return NotFound();
            }

            var music = await _context.Music
                .FirstOrDefaultAsync(m => m.MusicId == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }

        

        private bool MusicExists(int id)
        {
            return (_context.Music?.Any(e => e.MusicId == id)).GetValueOrDefault();
        }
    }
}