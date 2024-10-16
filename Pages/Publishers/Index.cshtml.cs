using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maties_Andreea_lab2.Data;
using Maties_Andreea_lab2.Models;

namespace Maties_Andreea_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Maties_Andreea_lab2.Data.Maties_Andreea_lab2Context _context;

        public IndexModel(Maties_Andreea_lab2.Data.Maties_Andreea_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
