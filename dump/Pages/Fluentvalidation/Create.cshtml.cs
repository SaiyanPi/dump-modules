using dump.Data;
using dump.Model;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace dump.Pages.Fluentvalidation
{
    public class CreateModel : PageModel
    {
        private readonly DumpDbContext _db;
        private IValidator<ForFluent> _validator;
        public CreateModel(DumpDbContext db, IValidator<ForFluent> validator)
        {
            _db = db;
            _validator = validator; // Inject our validator.
        }

        [BindProperty]
        public ForFluent Client { get; set; }
     
        public async Task<IActionResult> OnPostAsync()
        {
            //ClientValidator validator = new ClientValidator();
            ValidationResult result = await _validator.ValidateAsync(Client);

            if (result.IsValid)

            {
                
                await _db.Fluent.AddAsync(Client);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            else

            {

                foreach (ValidationFailure error in result.Errors)

                {

                    //ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    result.AddToModelState(ModelState, "Client");  //using FluentValidation.AspNetCore;
                   
                }

            }
            return Page();

           
        }
    }
}
