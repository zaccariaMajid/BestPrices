using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPrices.Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http.Features;

namespace BestPrices.Site
{
    public class _CookieConsentPartialModel : PageModel
    {
        public readonly PriceDbContext Context;
        public _CookieConsentPartialModel(PriceDbContext ctx)
        {
            Context = ctx;
        }
        public void OnGet()
        {

        }
    }
}
