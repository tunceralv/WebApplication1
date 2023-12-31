using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Hasta
    {
        public int Hastaid { get; set; }
        public string HastaTc { get; set; } = null!;
        public string HastaAd { get; set; } = null!;
        public string HastaSoyad { get; set; } = null!;
        public string HastaEmail { get; set; } = null!;
        public string HastaTel { get; set; } = null!;
    }
}
