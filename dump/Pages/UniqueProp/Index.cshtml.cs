using dump.Data;
using dump.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dump.Pages.UniqueProp
{
    public class IndexModel : PageModel
    {
        private readonly DumpDbContext _db;
        public IndexModel(DumpDbContext db)
        {
            _db = db;
           
        }
        [BindProperty]
        public IEnumerable<ForUniqueProp> individuals { get; set; }

        public async Task OnGetAsync()
        {
            individuals = await _db.Emp.ToListAsync();
        }
    }
}

