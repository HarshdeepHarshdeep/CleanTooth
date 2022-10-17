using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CleanTooth.Data;
using System;
using System.Linq;

namespace CleanTooth.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CleanToothContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CleanToothContext>>()))
            {
                // Look for any movies.
                if (context.ToothPick.Any())
                {
                    return;   // DB has been seeded
                }

                context.ToothPick.AddRange(
                    new ToothPick
                    {
                        Material = "Steel",
                        Color ="Brown",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty ="5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "wood",
                        Color = "white",
                        Length = 9,
                        Width = 2,
                        Price = 110,
                        Quailty = "7",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel1",
                        Color = "Brown1",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel2",
                        Color = "Brown2",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel3",
                        Color = "Brown3",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel4",
                        Color = "Brown4",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel5",
                        Color = "Brown5",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel6",
                        Color = "Brown6",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel7",
                        Color = "Brown7",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    },

                    new ToothPick
                    {
                        Material = "Steel8",
                        Color = "Brown8",
                        Length = 10,
                        Width = 4,
                        Price = 100,
                        Quailty = "5",
                        Rating = 1.5M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}