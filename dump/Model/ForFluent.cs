using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace dump.Model
{
    public class ForFluent
    {
        public int Id { get; set; }
        [Display(Name ="Forename")]
        public string ClientForeName { get; set; }
        [Display(Name = "Surname")]
        public string ClientSurName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Discount { get; set; }
    }

    public class ClientValidator: AbstractValidator<ForFluent>
    {
        public ClientValidator()
        {
            RuleFor(x => x.ClientForeName).NotNull().MinimumLength(3).MaximumLength(15);
            RuleFor(x => x.ClientSurName).NotNull().MinimumLength(2).MaximumLength(15);
            RuleFor(x => x.BirthDate).Must(AgeValidate).WithMessage("Invalid Date, Age must be above 18.");
            RuleFor(x => x.Age).InclusiveBetween(18, 99).WithMessage("Age must be above 18.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email address is required.");
            RuleFor(x => x.Address).Length(20, 250).WithMessage("Address must be between 20 to 250 words.");
            RuleFor(x => x.Phone).Length(10).WithMessage("Phone number is not valid.");
            RuleFor(x => x.Discount).InclusiveBetween(0, 75).WithMessage("Discount is not valid, discount limit is 75.00%.");
        }

        private bool AgeValidate(DateTime value)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Convert.ToDateTime(value).Year;

            if (age < 18)

            {

                return false;

            }

            else

            {

                return true;

            }

        }
    }

   
}
