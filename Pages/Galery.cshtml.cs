using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;

namespace RimeInkArt.Pages
{
    public class GaleryModel : PageModel
    {


        public IEnumerable<string> Images { get; set; }

        public void OnGet() => Images = Directory.GetFiles(@"wwwroot/images/portfolio_kepek/");
    }
}
