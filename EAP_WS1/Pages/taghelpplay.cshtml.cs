using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP_WS1.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public string message { get; set; } = "";

        [BindProperty]
        public int? Number1 { get; set; }

        [BindProperty]
        public int? age { get; set; }

        [BindProperty]
        public Decimal? savings { get; set; }

        [BindProperty]
        public Double? height { get; set; }

        [BindProperty]
        public float? cholesterol { get; set; }

        [BindProperty]
        public DateTime dateOfBirth { get; set; }

        [BindProperty]
        public bool isContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }


        public void OnGet()
        {

        }
        public void OnPost()
        {
            message = $"Number entered is: {Number1}; Age is: {age}; Savings are: {savings}; Height is: {height}; Cholesterol levels are: {cholesterol}; Date of birth: {dateOfBirth}; Is contact allowed? {isContactAllowed}; Favourite season {Season} ";
        }
    }
}