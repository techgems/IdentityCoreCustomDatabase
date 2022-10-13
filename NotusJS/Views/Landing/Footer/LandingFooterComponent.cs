﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Footer;

[HtmlTargetElement("landing-footer")]
public class LandingFooterComponent : RazorComponentTagHelper
{
    public LandingFooterComponent() : base("~/Views/Landing/Footer/Footer.cshtml")
    {
    }
}