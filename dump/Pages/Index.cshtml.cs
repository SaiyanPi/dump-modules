using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dump.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Greeting { get; set; }
        public void OnGet()
        {
            Greeting = "Good Evening Neerajan.";
            if(DateTime.Now.Hour < 18)
            {
                Greeting = "Good Afternoon Neerajan.";
            }
            if(DateTime.Now.Hour < 12)
            {
                Greeting = "Good Morning Neerajan.";
            }
        }
    }
}
