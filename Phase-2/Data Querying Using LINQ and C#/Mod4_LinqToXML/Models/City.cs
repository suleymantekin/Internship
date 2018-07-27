﻿using System;
using System.Collections.Generic;

namespace Mod4_LinqToXML.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public Country CountryCodeNavigation { get; set; }
    }
}
