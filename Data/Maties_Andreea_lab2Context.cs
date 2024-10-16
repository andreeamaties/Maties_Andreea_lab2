using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maties_Andreea_lab2.Models;

namespace Maties_Andreea_lab2.Data
{
    public class Maties_Andreea_lab2Context : DbContext
    {
        public Maties_Andreea_lab2Context (DbContextOptions<Maties_Andreea_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Maties_Andreea_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Maties_Andreea_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
