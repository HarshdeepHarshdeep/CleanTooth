using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanTooth.Models
{
    public class ToothPick
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Quailty { get; set; }

        [Column(TypeName = "decimal(2, 1)")]
        public decimal Rating { get; set; }






    }
}