using dump.Data;
using System.ComponentModel.DataAnnotations;



namespace dump.Model
{
    public class ForUniqueProp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [UniqueRole]
        public string? Role { get; set; }

        [UniqueCard]
        public int Card { get; set; }
        public string Section { get; set; }

    }

    public class UniqueRoleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object role,
            ValidationContext validationContext)
        {
            var context = (DumpDbContext)validationContext.GetService(typeof(DumpDbContext));
            if(role == null)
            {
                return ValidationResult.Success;
            }
           else
            {
                if (!context.Emp.Any(a => a.Role == role.ToString()) || role == null)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("Role already exists.");
            }
           
        }
    }

    public class UniqueCardAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object card,
            ValidationContext validationContext)
        {
            var context = (DumpDbContext)validationContext.GetService(typeof(DumpDbContext));
            if (!context.Emp.Any(a => a.Card == Convert.ToInt32(card)))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Card already exists.");
        }
    }
}



