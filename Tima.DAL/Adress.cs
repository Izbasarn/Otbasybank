﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public class Adress
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
     
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home  { get; set; }
    }
}
