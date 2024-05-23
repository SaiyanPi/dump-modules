using dump.Data;
using dump.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace dump.Pages.Fluentvalidation
{
    public class IndexModel : PageModel
    {
       
        private readonly DumpDbContext _db;
        public IndexModel(DumpDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ForFluent> clients { get; set; }
        public async Task OnGetAsync()
        {
            clients = await _db.Fluent.ToListAsync();
        }

    }
}
