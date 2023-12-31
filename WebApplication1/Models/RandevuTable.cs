using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class RandevuTable
    {
        public int Randevuid { get; set; }
        public string HastaTc { get; set; } = null!;
        public string HastaAd { get; set; } = null!;
        public string HastaSoyad { get; set; } = null!;
        public string HastaTel { get; set; } = null!;
        public string Bolum { get; set; } = null!;
        public string DoktorAd { get; set; } = null!;
        public string DoktorSoyad { get; set; } = null!;
        public string RandevuSaati { get; set; } = null!;
        public string RandevuGunu { get; set; } = null!;
    }
}
