using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class AdminTable
    {
        public int Adminid { get; set; }
        public string AdminEmail { get; set; } = null!;
        public string Adminsifre { get; set; } = null!;
    }
}
