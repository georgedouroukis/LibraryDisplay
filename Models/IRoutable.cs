﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Models
{
    internal interface IRoutable
    {
        public int id { get; set; }
        string route { get; set; }

    }
}
