﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{
    class Box
    {
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }

        public override String ToString()
        {
            return $@"({Height}, {Length}, {Width})";
        }
    }
}
