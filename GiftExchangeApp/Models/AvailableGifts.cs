using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchangeApp.Models
{
    public class AvailableGifts
    {
        public int Id { get; set; }
       // public string Contents { get; set; }
        public string GiftHint { get; set; }
        public string WrappingPaperColor { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<double> Depth { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<bool> IsOpened { get; set; }
    }
}