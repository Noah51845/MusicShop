using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Models;

namespace MusicSchool.Data
{
    public class MusicShopContext : DbContext
    {
        public MusicShopContext (DbContextOptions<MusicShopContext> options)
            : base(options)
        {
        }

        public DbSet<MusicSchool.Models.Music> Music { get; set; } = default!;
    }
}
