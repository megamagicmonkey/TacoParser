﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }


        public void WhoLikesTacos()
        {
            Console.WriteLine("Who doesn't like tacos?");
        }
    }
}
