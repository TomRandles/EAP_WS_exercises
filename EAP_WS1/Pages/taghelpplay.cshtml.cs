using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EAP_WS1.Pages
{
    public class taghelpplayModel : PageModel
    {
        

        [BindProperty]
        public string message { get; set; } = "";

        [BindProperty]
        [Display(Name ="Uimhir amháin")]
        public int? Number1 { get; set; }

        [BindProperty]
        public int? age { get; set; }

        [BindProperty]
        public Decimal? savings { get; set; }

        [BindProperty]
        public Double? height { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime newDateOfBirth { get; set; }

        [BindProperty]
        [DataType(DataType.PhoneNumber)]
        public DataType mobileNumber { get; set; }

        [BindProperty]
        [DataType(DataType.Url)]
        public DataType website { get; set; }

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
            message = $"Number entered is: {Number1}; Age is: {age}; Savings are: {savings}; Height is: {height}; Cholesterol levels are: {cholesterol}; New Date of birth: {newDateOfBirth}; Is contact allowed? {isContactAllowed}; Favourite season {Season}; website: {website}; mobile no:{mobileNumber} ";
        }
    }
}