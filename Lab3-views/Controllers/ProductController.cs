using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_views.Controllers
{
    public class ProductController : Controller
    {
            // GET: /Product/
            public string Index()
            {
                return "Product/Index is Displayed";
            }
            //
            // GET: /Products/Browse
            public string Browse()
            {
                return "Browse displayed.";
            }
            //
            // GET: /Products/Details/105
            public string Details()
            {
                return "Details displayed for Id=105";
            }
            //
            // GET: /Products/Location?Zip=44124
            public string Location()
            {
                return "Location displayed for zip=44124";
            }
        }
    }