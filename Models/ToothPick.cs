using System;
using System.ComponentModel.DataAnnotations;

namespace CleanTooth.Models
{
    public class ToothPick
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public decimal Price { get; set; }
        public string Quailty { get; set; }






    }
}