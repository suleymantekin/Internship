﻿using System;
using System.Collections.Generic;

namespace Mod3_Lab1_WorldApp.Models
{
    public partial class Continent
    {
        public Continent()
        {
            Country = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
