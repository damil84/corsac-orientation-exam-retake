﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookErrorReporter.Moduls
{
    public class Tickets
    {
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public string ReportedAt { get; set; }
    }
}
