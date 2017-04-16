﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Model
{
    public class Cell
    {
        public bool IsEmpty { get;}
        public bool IsHitted { get; set; }
    }

    enum CellStatus : byte
    {
        Empty = 0,
        Full = 1,
        Hit = 2,
        Past = 3
    }
}
