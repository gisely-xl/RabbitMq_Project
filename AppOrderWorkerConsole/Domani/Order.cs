﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrderWorkerConsole.Domani
{
   public sealed class  Order
    {
        public int OrderNumber { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
    }
}
