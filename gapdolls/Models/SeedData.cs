using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gapdolls.Data;
using System;
using System.Linq;
using System.Drawing;

using gapdolls.Models;

namespace MvcDolls.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new gapdollsContext(
        serviceProvider.GetRequiredService<
                DbContextOptions<gapdollsContext>>()))
        {
            // Look for any Dollss.
            if (context.Dolls.Any())
            {
                return;   // DB has been seeded
            }
            context.Dolls.AddRange(
                new Dolls
                {
                    Material = "Cotton",
                    Color = "Pink",
                    ManufactureDate = DateTime.Parse("2023-3-13"),
                    Articulation = "Movable Joints in the Arms",
                    Price = 25M,
                    Rating = 4,
                    Size = 10 * 8 * 9,
                    EyeColor = "Black",
                    SkinTone = "Orange",
                    Outfit = "Dress",
                    Accessories = "Hat",
                    Washability = "Yes"
                },
                new Dolls
                {
                    Material = "silicone",
                    Color = "purple",
                    ManufactureDate = DateTime.Parse("2024-12-21"),
                    Articulation = "No Movable Joints ",
                    Price = 52M,
                    Rating = 4,
                    Size = 10,
                    EyeColor = "Blue",
                    SkinTone = "White",
                    Outfit = "Firytale Outfit",
                    Accessories = "Lipstick",
                    Washability = "Yes"
                },
                new Dolls
                {
                    Material = "Porcelain",
                    Color = "Red",
                    ManufactureDate = DateTime.Parse("2022-09-14"),
                    Articulation = "Movable Joints in the Legs",
                    Price = 50M,
                    Rating = 5,
                    Size = 10,
                    EyeColor = "Black",
                    SkinTone = "White",
                    Outfit = "Formal Wear",
                    Accessories = "Bags And Purses",
                    Washability = "No"
                },
                new Dolls
                {
                    Material = "Vinyl",
                    Color = "Blue",
                    ManufactureDate = DateTime.Parse("2023-05-30"),
                    Articulation = "Movable Joints in the Arms",
                    Price = 15M,
                    Rating = 4,
                    Size = 5,
                    EyeColor = "Black",
                    SkinTone = "Black",
                    Outfit = "School Uniform",
                    Accessories = "Bottle",
                    Washability = "Yes"
                },
                new Dolls
                {
                    Material = "Silk",
                    Color = "Pink",
                    ManufactureDate = DateTime.Parse("2019-02-22"),
                    Articulation = "None",
                    Price = 2M,
                    Rating = 2,
                    Size = 2,
                    EyeColor = "Black",
                    SkinTone = "Black",
                    Outfit = "Dress",
                    Accessories = "Cap",
                    Washability = "Yes"
                },
                new Dolls
                {
                    Material = "Resin",
                    Color = "Sky Blue",
                    ManufactureDate = DateTime.Parse("2024-02-01"),
                    Articulation = "No Movable Joints",
                    Price = 23M,
                    Rating = 5,
                    Size = 7,
                    EyeColor = "Purple",
                    SkinTone = "White",
                    Outfit = "Fairytale Outfit",
                    Accessories = "Shoes, Jewelery",
                    Washability = "No"
                },
                new Dolls
                {
                    Material = "Cotton",
                    Color = "Blue",
                    ManufactureDate = DateTime.Parse("2024-01-01"),
                    Articulation = "Movable Joints in arms and legs",
                    Price = 32M,
                    Rating = 5,
                    Size = 17,
                    EyeColor = "Purple",
                    SkinTone = "Orange",
                    Outfit = "School Outfit",
                    Accessories = "Shoes",
                    Washability = "No"
                }

            );
            context.SaveChanges();
        }
    }
}