﻿using System;
using System.Collections.Generic;

namespace Mod4_LinqToXML.Models
{
    public partial class Region
    {
        public Region()
        {
            Country = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
