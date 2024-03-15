using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gapdolls.Models;
public class Dolls
{
    public int Id { get; set; }
    public string? Material { get; set; }
    public string? Color { get; set; }
    [Display(Name = "Manufacture Date")]
    [DataType(DataType.Date)]
    public DateTime ManufactureDate { get; set; }
    public string? Articulation { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    [Range(1, 100)]
    [DataType(DataType.Currency)]

    public decimal Price { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Rating { get; set; }


    public decimal Size { get; set; }
    public string? EyeColor { get; set; }
    public string? SkinTone { get; set; }
    public string? Outfit { get; set; }
    public string? Accessories { get; set; }
    public string? Washability { get; set; }
}