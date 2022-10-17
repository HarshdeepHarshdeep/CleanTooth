using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace CleanTooth.Models
{
    public class ToothPickViewModel
    {
        public List<ToothPick> ToothPicks { get; set; }
        public SelectList Color { get; set; }
        public string ToothPickColor { get; set; }
        public string SearchString { get; set; }
    }
}
