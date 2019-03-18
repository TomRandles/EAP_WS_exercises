using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EAP_WS1.Pages
{
    public class timeModel : PageModel
    {

        // Task 1
        public string[] daysOfWeek { set; get; } = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        [BindProperty]
        public bool[] daysSelected { set; get; } = new bool[7];


        // Task 2
        [BindProperty]
        public string[] selectedMonths { get; set; } = { };
 
        public List<SelectListItem> monthsOfYear { get; } = new List<SelectListItem>
        {
           new SelectListItem { Value="January", Text="January" },
           new SelectListItem { Value="February", Text="February" },
           new SelectListItem { Value="March", Text="March" },
           new SelectListItem { Value="April", Text="April" },
           new SelectListItem { Value="May", Text="May" },
           new SelectListItem { Value="June", Text="June" },
           new SelectListItem { Value="July", Text="July" },
           new SelectListItem { Value="August", Text="August" },
           new SelectListItem { Value="September", Text="September" },
           new SelectListItem { Value="October", Text="October" },
           new SelectListItem { Value="November", Text="November" },
           new SelectListItem { Value="December", Text="December" },

        };

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}