using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class DoktorTable
    {
        public int Doktorid { get; set; }
        public string DoktorAd { get; set; } = null!;
        public string DoktorSoyad { get; set; } = null!;
        public string CalismaSaatleri { get; set; } = null!;
        public string CalismaGunleri { get; set; } = null!;
        public string DoktorUnvan { get; set; } = null!;
    }
}
