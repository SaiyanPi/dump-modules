using dump.Data;
using dump.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dump.Pages.DoB
{
    public class IndexModel : PageModel
    {
        private readonly DumpDbContext _db;
        public IEnumerable<ForDoB> date { get; set; }
        public IndexModel(DumpDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            date = _db.DoB;
        }

        public ForDoB dates { get; set; }
        public void OnPost()
        {

        }
    }
}
