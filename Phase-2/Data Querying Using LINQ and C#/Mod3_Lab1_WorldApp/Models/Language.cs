﻿using System;
using System.Collections.Generic;

namespace Mod3_Lab1_WorldApp.Models
{
    public partial class Language
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public bool? IsOfficial { get; set; }
        public float Percentage { get; set; }

        public Country CountryCodeNavigation { get; set; }
    }
}
