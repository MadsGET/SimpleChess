﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    class Rook : Piece
    {
        public Rook(string symbol = "TRN") : base(symbol) { }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}
