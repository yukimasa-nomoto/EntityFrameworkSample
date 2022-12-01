using System;
using System.Collections.Generic;

namespace ContosoPizza.Models2
{
    public partial class Dmline
    {
        public string DasBlockNo { get; set; } = null!;
        public string DasCellNo { get; set; } = null!;
        public string? PpsIndicatorNo { get; set; }
        public byte? LineQty { get; set; }
        public DateTime RegistDate { get; set; }
        public string? RegistPname { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string? LastUpdatePname { get; set; }
    }
}
