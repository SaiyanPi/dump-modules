using dump.Data;
using dump.Model;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dump.Pages.UniqueProp
{
    public class CreateModel : PageModel
    {
        private readonly DumpDbContext _db;
      
        public CreateModel(DumpDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ForUniqueProp Detail { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {          
            if (ModelState.IsValid)
            {
                await _db.Emp.AddAsync(Detail);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            else
            
                return Page();
        }
    }
}
