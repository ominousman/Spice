﻿using System.Web;
using System.Web.Mvc;

namespace Spice_Test_One
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}